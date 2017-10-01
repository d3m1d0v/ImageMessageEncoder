using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageMessageEncoder
{
    public partial class MainForm : Form
    {
        ImageMessageEncodeManager encodeManager;
        ImageMessageEncodeManager decodeManager;

        public MainForm()
        {
            InitializeComponent();
            
            symbolsCountInEncTextLbl.Text = 
                string.Format("Кол-во символов: {0}", textToEncRTB.TextLength);
            linesCountInEncTextLbl.Text =
                string.Format("Кол-во строк: {0}", textToEncRTB.Lines.Length);

            encodeManager = new ImageMessageEncodeManager(null);
            decodeManager = new ImageMessageEncodeManager(null);
        }

        ////////////////////////////////////////////////////////////////////////////////////

        private void encPerformBtn_Click(object sender, EventArgs e)
        {
            if (!CanEncodingBePerformed())
            {
                MessageBox.Show(this, "Что-то пошло не так...", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string path = pathToSaveImageTB.Text;

            try
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
                {
                    encodeManager.EncodeMessageToImage(textToEncRTB.Text).Save(fs, ImageFormat.Png);
                }
                
                MessageBox.Show(this, string.Format("{0} {1}",
                                            "Изображение с закодированным сообщением было сохранено по адресу",
                                            path),
                            "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show(this, "Ошибка: невозможно вместить всё сообщение в эту картинку!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Ошибка при записи файла", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void decPerformBtn_Click(object sender, EventArgs e)
        {
            if (origImagePB.Image == null || changedImagePB.Image == null)
            {
                MessageBox.Show("Error");
                return;
            }

            try
            {
                decodedMessageRTB.Text =
                    decodeManager.DecodeMessageFromImage((Bitmap)changedImagePB.Image);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show(this, "Невозможно декодировать сообщения: разные картинки", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////

        private void encImageChooseBtn_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;

                Bitmap image = LoadImageFromFS(path);

                if(image != null)
                {
                    imageToEncPB.Image = image;
                    encodeManager.OriginalImage = image;

                    WriteTextToTextBox(pathToImageTB, path);

                    EncPerformBtnEnabler();
                }
            }
        }

        private void encImageSaveBtn_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                WriteTextToTextBox(pathToSaveImageTB, saveFileDialog1.FileName);
                EncPerformBtnEnabler();
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////

        private void decOrigImageChooseBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;

                Bitmap image = LoadImageFromFS(path);

                if (image != null)
                {
                    decodeManager.OriginalImage = image;
                    origImagePB.Image = image;

                    WriteTextToTextBox(decOrigImagePathTB, path);
                }
            }
        }

        private void decChangedImageChooseBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;

                Bitmap image = LoadImageFromFS(path);

                if (image != null)
                {
                    changedImagePB.Image = image;

                    WriteTextToTextBox(decChangedImagePathTB, path);
                }
            }
        }

        private void saveDecodedMessageBtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = saveFileDialog2.FileName;
                    using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.UTF8))
                    {
                        foreach (string str in decodedMessageRTB.Lines)
                        {
                            sw.WriteLine(str);
                        }
                    }

                    MessageBox.Show(this, string.Format("{0} {1}",
                                        "Сообщение было записано в файл по адресу",
                                        path),
                        "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show(this, "Ошибка при записи файла", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////

        private void textToEncRTB_TextChanged(object sender, EventArgs e)
        {
            RichTextBox rtb = sender as RichTextBox;

            symbolsCountInEncTextLbl.Text =
                string.Format("Кол-во символов: {0}", rtb.TextLength);

            linesCountInEncTextLbl.Text =
                string.Format("Кол-во строк: {0}", rtb.Lines.Length);

            EncPerformBtnEnabler();
        }

        private void decodedMessageRTB_TextChanged(object sender, EventArgs e)
        {
            saveDecodedMessageBtn.Enabled = ((sender as RichTextBox).TextLength > 0) ? true : false;
        }

        ////////////////////////////////////////////////////////////////////////////////////

        private void EncPerformBtnEnabler()
        {
            encPerformBtn.Enabled = CanEncodingBePerformed();
        }

        private bool CanEncodingBePerformed()
        {
            return pathToImageTB.TextLength > 0 && 
                pathToSaveImageTB.TextLength > 0 &&
                textToEncRTB.TextLength > 0;
        }

        private void WriteTextToTextBox(TextBox tb, string text)
        {
            tb.Text = text;
            tb.SelectionStart = tb.TextLength;
            tb.ScrollToCaret();
        }

        private Bitmap LoadImageFromFS(string pathToImage)
        {
            Bitmap image = null;

            try
            {
                using (FileStream fs = new FileStream(pathToImage, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    image = new Bitmap(fs, false);
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(this, "Ошибка при загрузке файла\nФайл не найден", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            { 
                MessageBox.Show(this, "Ошибка при загрузке файла", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return image;
        }
    }
}
