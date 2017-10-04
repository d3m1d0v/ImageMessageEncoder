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

            textToEncRTB.AllowDrop = true;
            textToEncRTB.DragEnter += textToEncRTB_DragEnter;
            textToEncRTB.DragDrop += textToEncRTB_DragDrop;

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

            ManageEncodeControls(false);

            object[] objs = new object[2];
            objs[0] = textToEncRTB.Text;
            objs[1] = pathToSaveImageTB.Text;

            encodeBgWorker.RunWorkerAsync(objs);
        }

        private void decPerformBtn_Click(object sender, EventArgs e)
        {
            if (!CanDecodingBePerformed())
            {
                MessageBox.Show("Error");
                return;
            }
            
            if(decodeManager.OriginalImage != origImagePB.Image)
            {
                decodeManager.OriginalImage = (Bitmap)origImagePB.Image;
            }

            ManageDecodeControls(false);

            decodeBgWorker.RunWorkerAsync();
        }

        ////////////////////////////////////////////////////////////////////////////////////

        private void encImageChooseBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK &&
                LoadImage(openFileDialog1.FileName, imageToEncPB, pathToImageTB))
            {
                encodeManager.OriginalImage = (Bitmap)imageToEncPB.Image;
                EncPerformBtnEnabler();
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
                LoadImage(openFileDialog1.FileName, origImagePB, decOrigImagePathTB);
            }
        }

        private void decChangedImageChooseBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LoadImage(openFileDialog1.FileName, changedImagePB, decChangedImagePathTB);
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

        private void encImageTLP_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (paths.Length == 1 && paths[0].ToLower().EndsWith(".png"))
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void encImageTLP_DragDrop(object sender, DragEventArgs e)
        {
            if (LoadImage(((string[])e.Data.GetData(DataFormats.FileDrop))[0], imageToEncPB, pathToImageTB))
            {
                encodeManager.OriginalImage = (Bitmap)imageToEncPB.Image;
                EncPerformBtnEnabler();
            }
        }

        private void pictureBoxesToDecTLP_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (
                    paths.Length == 1 && paths[0].ToLower().EndsWith(".png") ||
                    paths.Length == 2 && paths[0].ToLower().EndsWith(".png") &&
                        paths[1].ToLower().EndsWith(".png")
                    )
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pictureBoxesToDecTLP_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files.Length > 1)
            {
                Image image0 = LoadImageFromFS(files[0]);
                Image image1 = LoadImageFromFS(files[1]);

                if (image0 != null && image1 != null)
                {
                    if (!image0.Equals(origImagePB.Image))
                    {
                        origImagePB.Image = image0;
                        WriteTextToTextBox(decOrigImagePathTB, files[0]);
                    }

                    if (!image1.Equals(changedImagePB.Image))
                    {
                        WriteTextToTextBox(decChangedImagePathTB, files[1]);
                        changedImagePB.Image = image1;
                    }
                }
            }
            else
            {
                if (e.X < changedImagePB.PointToScreen(Point.Empty).X)
                {
                    LoadImage(files[0], origImagePB, decOrigImagePathTB);
                }
                else
                {
                    LoadImage(files[0], changedImagePB, decChangedImagePathTB);
                }
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////

        private void encodeBgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Bitmap image;

            try
            {
                image = encodeManager.EncodeMessageToImage((string)((object[])e.Argument)[0]);
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception("Ошибка: невозможно вместить всё сообщение в эту картинку!", ex);
            }

            try
            {
                using (FileStream fs = new FileStream((string)((object[])e.Argument)[1],
                    FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
                {
                    image.Save(fs, ImageFormat.Png);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при записи файла", ex);
            }
        }

        private void encodeBgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(this, e.Error.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(this, string.Format("{0} {1}",
                                        "Изображение с закодированным сообщением было сохранено по адресу",
                                        pathToSaveImageTB.Text),
                                "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ManageEncodeControls(true);
        }

        private void decodeBgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                e.Result =
                    decodeManager.DecodeMessageFromImage((Bitmap)changedImagePB.Image);
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception("Невозможно декодировать сообщение: разные картинки", ex);
            }
        }

        private void decodeBgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(this, e.Error.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decodedMessageRTB.Text = (string)e.Result;

            ManageDecodeControls(true);
        }

        ////////////////////////////////////////////////////////////////////////////////////

        private void textToEncRTB_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (paths.Length == 1 &&
                    (paths[0].ToLower().EndsWith(".txt") ||
                    paths[0].ToLower().EndsWith(".rtf")))
                {

                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void textToEncRTB_DragDrop(object sender, DragEventArgs e)
        {
            string[] paths = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (paths != null && !string.IsNullOrWhiteSpace(paths[0]))
            {
                RichTextBoxStreamType type = RichTextBoxStreamType.PlainText;
                if (paths[0].ToLower().EndsWith(".rtf"))
                {
                    type = RichTextBoxStreamType.RichText;
                }

                RichTextBox rtb = sender as RichTextBox;
                rtb.Clear();
                try
                {
                    rtb.LoadFile(paths[0], type);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                EncPerformBtnEnabler();
            }
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

        private bool CanDecodingBePerformed()
        {
            return origImagePB.Image != null &&
                changedImagePB.Image != null;
        }

        private void WriteTextToTextBox(TextBox tb, string text)
        {
            tb.Text = text;
            tb.SelectionStart = tb.TextLength;
            tb.ScrollToCaret();
        }

        private bool LoadImage(string path, PictureBox pb, TextBox tb)
        {
            bool isImageLoaded = false;

            Image image = LoadImageFromFS(path);
            if(image != null && !image.Equals(pb.Image))
            {
                pb.Image = image;
                WriteTextToTextBox(tb, path);
                isImageLoaded = true;
            }

            return isImageLoaded;
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

        private void ManageEncodeControls(bool state)
        {
            encImageChooseBtn.Enabled = state;
            encImageSaveBtn.Enabled = state;
            textToEncRTB.ReadOnly = !state;
            textToEncRTB.AllowDrop = state;
            encPerformBtn.Enabled = state;
            encImageTLP.AllowDrop = state;

            encPerformBtn.Text = state ? "Выполнить" : "Выполняется...";
        }

        private void ManageDecodeControls(bool state)
        {
            decPerformBtn.Enabled = state;
            decOrigImageChooseBtn.Enabled = state;
            decChangedImageChooseBtn.Enabled = state;
            pictureBoxesToDecTLP.AllowDrop = state;

            decPerformBtn.Text = state ? "Выполнить" : "Выполняется...";
        }
    }
}
