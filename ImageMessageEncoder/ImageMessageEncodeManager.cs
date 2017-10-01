using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ImageMessageEncoder
{
    class ImageMessageEncodeManager
    {
        private Bitmap originalImage;
        private byte[] originalImageByteArray;

        public Bitmap OriginalImage
        {
            get
            {
                return originalImage;
            }

            set
            {
                originalImage = (value != null) ? value : new Bitmap(1, 1);
                originalImageByteArray = null;
            }
        }

        public ImageMessageEncodeManager(Bitmap image)
        {
            OriginalImage = image;
        }

        public Bitmap EncodeMessageToImage(string message)
        {
            if (originalImageByteArray == null)
            {
                originalImageByteArray = ByteArrayFromBitmap(OriginalImage);
            }

            byte[] values = originalImageByteArray;
            byte[] messageByteArray = Encoding.UTF8.GetBytes(message);

            byte current;
            int index = 0;
            for(int i = 0; i < messageByteArray.Length; i++)
            {
                if (index + 7 >= values.Length)
                {
                    throw new InvalidOperationException("OriginalImage is too small to encode whole message");
                }

                current = messageByteArray[i];

                values[index] = (byte)((values[index] & 1) == 0 ? 
                    values[index] + (current >> 7) : values[index] - (current >> 7));
                ++index;

                values[index] = (byte)((values[index] & 1) == 0 ? 
                    values[index] + ((current & 64) >> 6) : values[index] - ((current & 64) >> 6)); // 64 == 0100_0000b
                ++index;

                values[index] = (byte)((values[index] & 1) == 0 ? 
                    values[index] + ((current & 32) >> 5) : values[index] - ((current & 32) >> 5)); // 32 == 0010_0000b
                ++index;

                values[index] = (byte)((values[index] & 1) == 0 ? 
                    values[index] + ((current & 16) >> 4) : values[index] - ((current & 16) >> 4)); // 16 == 0001_0000b
                ++index;

                values[index] = (byte)((values[index] & 1) == 0 ? 
                    values[index] + ((current & 8) >> 3) : values[index] - ((current & 8) >> 3)); // 8 == 0000_1000b
                ++index;

                values[index] = (byte)((values[index] & 1) == 0 ? 
                    values[index] + ((current & 4) >> 2) : values[index] - ((current & 4) >> 2)); // 4 == 0000_0100b
                ++index;

                values[index] = (byte)((values[index] & 1) == 0 ? 
                    values[index] + ((current & 2) >> 1) : values[index] - ((current & 2) >> 1)); // 2 == 0000_0010b
                ++index;

                values[index] = (byte)((values[index] & 1) == 0 ? 
                    values[index] + (current & 1) : values[index] - (current & 1));
                ++index;
            }

            ///////////////////////////////////////////////////////
            Bitmap newImage = new Bitmap(OriginalImage.Width, OriginalImage.Height, OriginalImage.PixelFormat);

            BitmapData newImageData = newImage.LockBits(
                new Rectangle(0, 0, newImage.Width, newImage.Height),
                ImageLockMode.ReadWrite,
                newImage.PixelFormat);

            int bytes = Math.Abs(newImageData.Stride) * newImageData.Height;

            Marshal.Copy(values, 0, newImageData.Scan0, bytes);

            newImage.UnlockBits(newImageData);

            return newImage;
        }

        public string DecodeMessageFromImage(Bitmap changedImage)
        {
            if (originalImage.Equals(changedImage))
            {
                return "";
            }

            if (OriginalImage.PixelFormat != changedImage.PixelFormat)
            {
                throw new InvalidOperationException("Different images");
            }

            if (originalImageByteArray == null)
            {
                originalImageByteArray = ByteArrayFromBitmap(OriginalImage);
            }

            byte[] original = originalImageByteArray;
            byte[] changed = ByteArrayFromBitmap(changedImage);

            if (original.Length != changed.Length)
            {
                throw new InvalidOperationException("Different images");
            }


            int symbol;
            int index = 0;
            List<byte> message = new List<byte>();

            do
            {
                symbol = (original[index] ^ changed[index]) << 7;
                index++;

                symbol |= ((original[index] ^ changed[index]) & 1) << 6;
                index++;

                symbol |= ((original[index] ^ changed[index]) & 1) << 5;
                index++;

                symbol |= ((original[index] ^ changed[index]) & 1) << 4;
                index++;

                symbol |= ((original[index] ^ changed[index]) & 1) << 3;
                index++;

                symbol |= ((original[index] ^ changed[index]) & 1) << 2;
                index++;

                symbol |= ((original[index] ^ changed[index]) & 1) << 1;
                index++;

                symbol |= (original[index] ^ changed[index]) & 1;
                index++;

                message.Add((byte)symbol);
            }
            while (symbol != '\0' && (original.Length - index) >= 8);

            return Encoding.UTF8.GetString(message.ToArray());
        }

        private static byte[] ByteArrayFromBitmap(Bitmap image)
        {
            BitmapData imageData = image.LockBits(
                new Rectangle(0, 0, image.Width, image.Height),
                ImageLockMode.ReadOnly,
                image.PixelFormat);

            int bytes = Math.Abs(imageData.Stride) * imageData.Height;
            byte[] array = new byte[bytes];

            Marshal.Copy(imageData.Scan0, array, 0, bytes);

            image.UnlockBits(imageData);

            return array;
        }
    }
}
