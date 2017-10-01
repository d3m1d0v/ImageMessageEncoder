namespace ImageMessageEncoder
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.linesCountInEncTextLbl = new System.Windows.Forms.Label();
            this.symbolsCountInEncTextLbl = new System.Windows.Forms.Label();
            this.encPerformBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textToEncRTB = new System.Windows.Forms.RichTextBox();
            this.encImageSaveBtn = new System.Windows.Forms.Button();
            this.pathToSaveImageTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.encImageChooseBtn = new System.Windows.Forms.Button();
            this.pathToImageTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageToEncPB = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.changedImagePB = new System.Windows.Forms.PictureBox();
            this.origImagePB = new System.Windows.Forms.PictureBox();
            this.saveDecodedMessageBtn = new System.Windows.Forms.Button();
            this.decPerformBtn = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.decodedMessageRTB = new System.Windows.Forms.RichTextBox();
            this.decChangedImageChooseBtn = new System.Windows.Forms.Button();
            this.decChangedImagePathTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.decOrigImageChooseBtn = new System.Windows.Forms.Button();
            this.decOrigImagePathTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageToEncPB)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changedImagePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.origImagePB)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 553);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.linesCountInEncTextLbl);
            this.tabPage1.Controls.Add(this.symbolsCountInEncTextLbl);
            this.tabPage1.Controls.Add(this.encPerformBtn);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.textToEncRTB);
            this.tabPage1.Controls.Add(this.encImageSaveBtn);
            this.tabPage1.Controls.Add(this.pathToSaveImageTB);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.encImageChooseBtn);
            this.tabPage1.Controls.Add(this.pathToImageTB);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.imageToEncPB);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(774, 524);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Закодировать";
            // 
            // linesCountInEncTextLbl
            // 
            this.linesCountInEncTextLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linesCountInEncTextLbl.AutoSize = true;
            this.linesCountInEncTextLbl.Location = new System.Drawing.Point(405, 438);
            this.linesCountInEncTextLbl.Name = "linesCountInEncTextLbl";
            this.linesCountInEncTextLbl.Size = new System.Drawing.Size(118, 17);
            this.linesCountInEncTextLbl.TabIndex = 12;
            this.linesCountInEncTextLbl.Text = "Кол-во строк = ?";
            // 
            // symbolsCountInEncTextLbl
            // 
            this.symbolsCountInEncTextLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.symbolsCountInEncTextLbl.AutoSize = true;
            this.symbolsCountInEncTextLbl.Location = new System.Drawing.Point(405, 419);
            this.symbolsCountInEncTextLbl.Name = "symbolsCountInEncTextLbl";
            this.symbolsCountInEncTextLbl.Size = new System.Drawing.Size(143, 17);
            this.symbolsCountInEncTextLbl.TabIndex = 11;
            this.symbolsCountInEncTextLbl.Text = "Кол-во символов = ?";
            // 
            // encPerformBtn
            // 
            this.encPerformBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.encPerformBtn.Enabled = false;
            this.encPerformBtn.Location = new System.Drawing.Point(668, 470);
            this.encPerformBtn.Name = "encPerformBtn";
            this.encPerformBtn.Size = new System.Drawing.Size(98, 46);
            this.encPerformBtn.TabIndex = 10;
            this.encPerformBtn.Text = "Выполнить";
            this.encPerformBtn.UseVisualStyleBackColor = true;
            this.encPerformBtn.Click += new System.EventHandler(this.encPerformBtn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Текст, который необходимо спрятать";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(6, 470);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(656, 46);
            this.progressBar1.TabIndex = 8;
            // 
            // textToEncRTB
            // 
            this.textToEncRTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textToEncRTB.Location = new System.Drawing.Point(408, 156);
            this.textToEncRTB.Name = "textToEncRTB";
            this.textToEncRTB.Size = new System.Drawing.Size(358, 253);
            this.textToEncRTB.TabIndex = 7;
            this.textToEncRTB.Text = "";
            this.textToEncRTB.TextChanged += new System.EventHandler(this.textToEncRTB_TextChanged);
            // 
            // encImageSaveBtn
            // 
            this.encImageSaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.encImageSaveBtn.Location = new System.Drawing.Point(691, 89);
            this.encImageSaveBtn.Name = "encImageSaveBtn";
            this.encImageSaveBtn.Size = new System.Drawing.Size(75, 28);
            this.encImageSaveBtn.TabIndex = 6;
            this.encImageSaveBtn.Text = "Обзор";
            this.encImageSaveBtn.UseVisualStyleBackColor = true;
            this.encImageSaveBtn.Click += new System.EventHandler(this.encImageSaveBtn_Click);
            // 
            // pathToSaveImageTB
            // 
            this.pathToSaveImageTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pathToSaveImageTB.Location = new System.Drawing.Point(408, 92);
            this.pathToSaveImageTB.Name = "pathToSaveImageTB";
            this.pathToSaveImageTB.ReadOnly = true;
            this.pathToSaveImageTB.Size = new System.Drawing.Size(277, 22);
            this.pathToSaveImageTB.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сохранить картинку с текстом";
            // 
            // encImageChooseBtn
            // 
            this.encImageChooseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.encImageChooseBtn.Location = new System.Drawing.Point(691, 39);
            this.encImageChooseBtn.Name = "encImageChooseBtn";
            this.encImageChooseBtn.Size = new System.Drawing.Size(75, 28);
            this.encImageChooseBtn.TabIndex = 3;
            this.encImageChooseBtn.Text = "Обзор";
            this.encImageChooseBtn.UseVisualStyleBackColor = true;
            this.encImageChooseBtn.Click += new System.EventHandler(this.encImageChooseBtn_Click);
            // 
            // pathToImageTB
            // 
            this.pathToImageTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pathToImageTB.Location = new System.Drawing.Point(408, 42);
            this.pathToImageTB.Name = "pathToImageTB";
            this.pathToImageTB.ReadOnly = true;
            this.pathToImageTB.Size = new System.Drawing.Size(277, 22);
            this.pathToImageTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выбрать картинку";
            // 
            // imageToEncPB
            // 
            this.imageToEncPB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageToEncPB.BackColor = System.Drawing.SystemColors.ControlDark;
            this.imageToEncPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imageToEncPB.Location = new System.Drawing.Point(6, 6);
            this.imageToEncPB.Name = "imageToEncPB";
            this.imageToEncPB.Size = new System.Drawing.Size(396, 458);
            this.imageToEncPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageToEncPB.TabIndex = 0;
            this.imageToEncPB.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Controls.Add(this.saveDecodedMessageBtn);
            this.tabPage2.Controls.Add(this.decPerformBtn);
            this.tabPage2.Controls.Add(this.progressBar2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.decodedMessageRTB);
            this.tabPage2.Controls.Add(this.decChangedImageChooseBtn);
            this.tabPage2.Controls.Add(this.decChangedImagePathTB);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.decOrigImageChooseBtn);
            this.tabPage2.Controls.Add(this.decOrigImagePathTB);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(774, 524);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Раскодировать";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.changedImagePB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.origImagePB, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 268);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // changedImagePB
            // 
            this.changedImagePB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.changedImagePB.BackColor = System.Drawing.SystemColors.ControlDark;
            this.changedImagePB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.changedImagePB.Location = new System.Drawing.Point(383, 3);
            this.changedImagePB.Name = "changedImagePB";
            this.changedImagePB.Size = new System.Drawing.Size(374, 262);
            this.changedImagePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.changedImagePB.TabIndex = 0;
            this.changedImagePB.TabStop = false;
            // 
            // origImagePB
            // 
            this.origImagePB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.origImagePB.BackColor = System.Drawing.SystemColors.ControlDark;
            this.origImagePB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.origImagePB.Location = new System.Drawing.Point(3, 3);
            this.origImagePB.Name = "origImagePB";
            this.origImagePB.Size = new System.Drawing.Size(374, 262);
            this.origImagePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.origImagePB.TabIndex = 0;
            this.origImagePB.TabStop = false;
            // 
            // saveDecodedMessageBtn
            // 
            this.saveDecodedMessageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveDecodedMessageBtn.Enabled = false;
            this.saveDecodedMessageBtn.Location = new System.Drawing.Point(213, 384);
            this.saveDecodedMessageBtn.Name = "saveDecodedMessageBtn";
            this.saveDecodedMessageBtn.Size = new System.Drawing.Size(154, 80);
            this.saveDecodedMessageBtn.TabIndex = 14;
            this.saveDecodedMessageBtn.Text = "Сохранить сообщение в файл";
            this.saveDecodedMessageBtn.UseVisualStyleBackColor = true;
            this.saveDecodedMessageBtn.Click += new System.EventHandler(this.saveDecodedMessageBtn_Click);
            // 
            // decPerformBtn
            // 
            this.decPerformBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.decPerformBtn.Location = new System.Drawing.Point(6, 470);
            this.decPerformBtn.Name = "decPerformBtn";
            this.decPerformBtn.Size = new System.Drawing.Size(98, 46);
            this.decPerformBtn.TabIndex = 13;
            this.decPerformBtn.Text = "Выполнить";
            this.decPerformBtn.UseVisualStyleBackColor = true;
            this.decPerformBtn.Click += new System.EventHandler(this.decPerformBtn_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar2.Location = new System.Drawing.Point(110, 470);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(656, 46);
            this.progressBar2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Полученное сообщение";
            // 
            // decodedMessageRTB
            // 
            this.decodedMessageRTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.decodedMessageRTB.Location = new System.Drawing.Point(373, 297);
            this.decodedMessageRTB.Name = "decodedMessageRTB";
            this.decodedMessageRTB.ReadOnly = true;
            this.decodedMessageRTB.Size = new System.Drawing.Size(393, 167);
            this.decodedMessageRTB.TabIndex = 10;
            this.decodedMessageRTB.Text = "";
            this.decodedMessageRTB.TextChanged += new System.EventHandler(this.decodedMessageRTB_TextChanged);
            // 
            // decChangedImageChooseBtn
            // 
            this.decChangedImageChooseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.decChangedImageChooseBtn.Location = new System.Drawing.Point(292, 350);
            this.decChangedImageChooseBtn.Name = "decChangedImageChooseBtn";
            this.decChangedImageChooseBtn.Size = new System.Drawing.Size(75, 28);
            this.decChangedImageChooseBtn.TabIndex = 9;
            this.decChangedImageChooseBtn.Text = "Обзор";
            this.decChangedImageChooseBtn.UseVisualStyleBackColor = true;
            this.decChangedImageChooseBtn.Click += new System.EventHandler(this.decChangedImageChooseBtn_Click);
            // 
            // decChangedImagePathTB
            // 
            this.decChangedImagePathTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.decChangedImagePathTB.Location = new System.Drawing.Point(9, 353);
            this.decChangedImagePathTB.Name = "decChangedImagePathTB";
            this.decChangedImagePathTB.ReadOnly = true;
            this.decChangedImagePathTB.Size = new System.Drawing.Size(277, 22);
            this.decChangedImagePathTB.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Выбрать картинку с сообщением";
            // 
            // decOrigImageChooseBtn
            // 
            this.decOrigImageChooseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.decOrigImageChooseBtn.Location = new System.Drawing.Point(292, 297);
            this.decOrigImageChooseBtn.Name = "decOrigImageChooseBtn";
            this.decOrigImageChooseBtn.Size = new System.Drawing.Size(75, 28);
            this.decOrigImageChooseBtn.TabIndex = 6;
            this.decOrigImageChooseBtn.Text = "Обзор";
            this.decOrigImageChooseBtn.UseVisualStyleBackColor = true;
            this.decOrigImageChooseBtn.Click += new System.EventHandler(this.decOrigImageChooseBtn_Click);
            // 
            // decOrigImagePathTB
            // 
            this.decOrigImagePathTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.decOrigImagePathTB.Location = new System.Drawing.Point(9, 300);
            this.decOrigImagePathTB.Name = "decOrigImagePathTB";
            this.decOrigImagePathTB.ReadOnly = true;
            this.decOrigImagePathTB.Size = new System.Drawing.Size(277, 22);
            this.decOrigImagePathTB.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Выбрать оригинальную картинку";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "PNG (*.png)|*.png";
            this.openFileDialog1.Multiselect = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "PNG (*.png)|*.png";
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.Filter = "TXT (*.txt)|*.txt";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Image Message Encoder";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageToEncPB)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.changedImagePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.origImagePB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox imageToEncPB;
        private System.Windows.Forms.Button encImageChooseBtn;
        private System.Windows.Forms.TextBox pathToImageTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button encImageSaveBtn;
        private System.Windows.Forms.TextBox pathToSaveImageTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RichTextBox textToEncRTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button encPerformBtn;
        private System.Windows.Forms.Label symbolsCountInEncTextLbl;
        private System.Windows.Forms.PictureBox origImagePB;
        private System.Windows.Forms.PictureBox changedImagePB;
        private System.Windows.Forms.Button decOrigImageChooseBtn;
        private System.Windows.Forms.TextBox decOrigImagePathTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button decChangedImageChooseBtn;
        private System.Windows.Forms.TextBox decChangedImagePathTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox decodedMessageRTB;
        private System.Windows.Forms.Button saveDecodedMessageBtn;
        private System.Windows.Forms.Button decPerformBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.Label linesCountInEncTextLbl;
    }
}

