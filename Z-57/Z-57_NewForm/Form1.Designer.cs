namespace Z_57_NewForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_FolderOfImages = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Stop = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox_OriginalImageFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_progressView = new System.Windows.Forms.Panel();
            this.label_progress = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.checkedListBox_ImagesClearName = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxVisibleHexOfImage = new System.Windows.Forms.CheckBox();
            this.panel_buttons = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox_VisualImage = new System.Windows.Forms.CheckBox();
            this.panel_ImagesHEX = new System.Windows.Forms.Panel();
            this.label_HammingLength = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_ImageTwoHEX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ImageOneHEX = new System.Windows.Forms.TextBox();
            this.label_imageOneName = new System.Windows.Forms.Label();
            this.textBox_ImageTwoName = new System.Windows.Forms.TextBox();
            this.textBox_ImageOneName = new System.Windows.Forms.TextBox();
            this.label_result = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_progressView.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel_buttons.SuspendLayout();
            this.panel_ImagesHEX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_FolderOfImages
            // 
            this.textBox_FolderOfImages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_FolderOfImages.Location = new System.Drawing.Point(6, 45);
            this.textBox_FolderOfImages.Name = "textBox_FolderOfImages";
            this.textBox_FolderOfImages.Size = new System.Drawing.Size(325, 20);
            this.textBox_FolderOfImages.TabIndex = 2;
            this.textBox_FolderOfImages.TextChanged += new System.EventHandler(this.textBox_FolderOfImages_TextChanged);
            this.textBox_FolderOfImages.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBox_FolderOfImages_MouseDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(6, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 309);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.button_Stop);
            this.groupBox1.Controls.Add(this.button_Start);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_FolderOfImages);
            this.groupBox1.Controls.Add(this.panel_progressView);
            this.groupBox1.Controls.Add(this.checkedListBox_ImagesClearName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 687);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки";
            // 
            // button_Stop
            // 
            this.button_Stop.Location = new System.Drawing.Point(179, 71);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(152, 39);
            this.button_Stop.TabIndex = 23;
            this.button_Stop.Text = "Остановить";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(6, 71);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(152, 39);
            this.button_Start.TabIndex = 22;
            this.button_Start.Text = "Начать";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.checkBox3);
            this.panel3.Controls.Add(this.radioButton6);
            this.panel3.Location = new System.Drawing.Point(6, 606);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 75);
            this.panel3.TabIndex = 21;
            this.panel3.Visible = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(9, 26);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(284, 30);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "Вынести изображение-источник при обнаружении \r\nего копий";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(9, 3);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(118, 17);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Вынести дубликат";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 583);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(335, 17);
            this.checkBox2.TabIndex = 20;
            this.checkBox2.Text = "Автоматически при обнаружении идентичного изображения:";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.textBox_OriginalImageFileName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(6, 372);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 100);
            this.panel2.TabIndex = 18;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(9, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(182, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Найти все дубликаты в списке";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(232, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.Text = "Найти дубликаты изображения в списке";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // textBox_OriginalImageFileName
            // 
            this.textBox_OriginalImageFileName.Location = new System.Drawing.Point(9, 68);
            this.textBox_OriginalImageFileName.Name = "textBox_OriginalImageFileName";
            this.textBox_OriginalImageFileName.Size = new System.Drawing.Size(302, 20);
            this.textBox_OriginalImageFileName.TabIndex = 8;
            this.textBox_OriginalImageFileName.Visible = false;
            this.textBox_OriginalImageFileName.TextChanged += new System.EventHandler(this.textBox_OriginalImageFileName_TextChanged);
            this.textBox_OriginalImageFileName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBox_OriginalImageFileName_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Имя изображения:";
            this.label2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Location = new System.Drawing.Point(6, 504);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 73);
            this.panel1.TabIndex = 19;
            this.panel1.Visible = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(9, 3);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(186, 17);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Вынести похожее изображение";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(9, 26);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(190, 17);
            this.radioButton4.TabIndex = 12;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Оставить его и учитывать далее";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(9, 49);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(208, 17);
            this.radioButton5.TabIndex = 13;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Оставить его и НЕ учитывать далее";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 481);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(321, 17);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Автоматизация при обнаружении похожего изображения:";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Выберите режим:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Путь к папке с изображениями:";
            // 
            // panel_progressView
            // 
            this.panel_progressView.Controls.Add(this.label_progress);
            this.panel_progressView.Controls.Add(this.progressBar1);
            this.panel_progressView.Location = new System.Drawing.Point(9, 116);
            this.panel_progressView.Name = "panel_progressView";
            this.panel_progressView.Size = new System.Drawing.Size(318, 134);
            this.panel_progressView.TabIndex = 24;
            // 
            // label_progress
            // 
            this.label_progress.AutoSize = true;
            this.label_progress.Location = new System.Drawing.Point(143, 39);
            this.label_progress.Name = "label_progress";
            this.label_progress.Size = new System.Drawing.Size(36, 13);
            this.label_progress.TabIndex = 23;
            this.label_progress.Text = "1 / 30";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 13);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(312, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 22;
            this.progressBar1.Value = 2;
            // 
            // checkedListBox_ImagesClearName
            // 
            this.checkedListBox_ImagesClearName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkedListBox_ImagesClearName.FormattingEnabled = true;
            this.checkedListBox_ImagesClearName.Location = new System.Drawing.Point(6, 116);
            this.checkedListBox_ImagesClearName.Name = "checkedListBox_ImagesClearName";
            this.checkedListBox_ImagesClearName.Size = new System.Drawing.Size(325, 214);
            this.checkedListBox_ImagesClearName.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.checkBoxVisibleHexOfImage);
            this.groupBox2.Controls.Add(this.panel_buttons);
            this.groupBox2.Controls.Add(this.checkBox_VisualImage);
            this.groupBox2.Controls.Add(this.panel_ImagesHEX);
            this.groupBox2.Controls.Add(this.label_imageOneName);
            this.groupBox2.Controls.Add(this.textBox_ImageTwoName);
            this.groupBox2.Controls.Add(this.textBox_ImageOneName);
            this.groupBox2.Controls.Add(this.label_result);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(358, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(634, 687);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация по сравнению";
            // 
            // checkBoxVisibleHexOfImage
            // 
            this.checkBoxVisibleHexOfImage.AutoSize = true;
            this.checkBoxVisibleHexOfImage.Checked = true;
            this.checkBoxVisibleHexOfImage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxVisibleHexOfImage.Location = new System.Drawing.Point(245, 22);
            this.checkBoxVisibleHexOfImage.Name = "checkBoxVisibleHexOfImage";
            this.checkBoxVisibleHexOfImage.Size = new System.Drawing.Size(111, 17);
            this.checkBoxVisibleHexOfImage.TabIndex = 21;
            this.checkBoxVisibleHexOfImage.Text = "Показывать хеш";
            this.checkBoxVisibleHexOfImage.UseVisualStyleBackColor = true;
            this.checkBoxVisibleHexOfImage.CheckedChanged += new System.EventHandler(this.checkBoxVisibleHexOfImage_CheckedChanged);
            // 
            // panel_buttons
            // 
            this.panel_buttons.Controls.Add(this.button2);
            this.panel_buttons.Controls.Add(this.button1);
            this.panel_buttons.Controls.Add(this.button3);
            this.panel_buttons.Location = new System.Drawing.Point(0, 424);
            this.panel_buttons.Name = "panel_buttons";
            this.panel_buttons.Size = new System.Drawing.Size(634, 176);
            this.panel_buttons.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(415, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 49);
            this.button2.TabIndex = 18;
            this.button2.Text = "Оставить и учитывать далее";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(415, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 49);
            this.button1.TabIndex = 17;
            this.button1.Text = "Вынести в отдельную папку";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(415, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 49);
            this.button3.TabIndex = 19;
            this.button3.Text = "Оставить и НЕ учитывать далее";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // checkBox_VisualImage
            // 
            this.checkBox_VisualImage.AutoSize = true;
            this.checkBox_VisualImage.Checked = true;
            this.checkBox_VisualImage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_VisualImage.Location = new System.Drawing.Point(6, 22);
            this.checkBox_VisualImage.Name = "checkBox_VisualImage";
            this.checkBox_VisualImage.Size = new System.Drawing.Size(233, 17);
            this.checkBox_VisualImage.TabIndex = 16;
            this.checkBox_VisualImage.Text = "Визуальное представление информации";
            this.checkBox_VisualImage.UseVisualStyleBackColor = true;
            this.checkBox_VisualImage.CheckedChanged += new System.EventHandler(this.checkBox_VisualImage_CheckedChanged);
            // 
            // panel_ImagesHEX
            // 
            this.panel_ImagesHEX.Controls.Add(this.label_HammingLength);
            this.panel_ImagesHEX.Controls.Add(this.label6);
            this.panel_ImagesHEX.Controls.Add(this.textBox_ImageTwoHEX);
            this.panel_ImagesHEX.Controls.Add(this.label7);
            this.panel_ImagesHEX.Controls.Add(this.label5);
            this.panel_ImagesHEX.Controls.Add(this.textBox_ImageOneHEX);
            this.panel_ImagesHEX.Location = new System.Drawing.Point(0, 382);
            this.panel_ImagesHEX.Name = "panel_ImagesHEX";
            this.panel_ImagesHEX.Size = new System.Drawing.Size(634, 36);
            this.panel_ImagesHEX.TabIndex = 6;
            this.panel_ImagesHEX.Visible = false;
            // 
            // label_HammingLength
            // 
            this.label_HammingLength.AutoSize = true;
            this.label_HammingLength.Location = new System.Drawing.Point(362, 11);
            this.label_HammingLength.Name = "label_HammingLength";
            this.label_HammingLength.Size = new System.Drawing.Size(13, 13);
            this.label_HammingLength.TabIndex = 16;
            this.label_HammingLength.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Длина Хэмминга:";
            // 
            // textBox_ImageTwoHEX
            // 
            this.textBox_ImageTwoHEX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ImageTwoHEX.Location = new System.Drawing.Point(449, 7);
            this.textBox_ImageTwoHEX.Name = "textBox_ImageTwoHEX";
            this.textBox_ImageTwoHEX.Size = new System.Drawing.Size(179, 20);
            this.textBox_ImageTwoHEX.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Хеш:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Хеш:";
            // 
            // textBox_ImageOneHEX
            // 
            this.textBox_ImageOneHEX.Location = new System.Drawing.Point(43, 7);
            this.textBox_ImageOneHEX.Name = "textBox_ImageOneHEX";
            this.textBox_ImageOneHEX.Size = new System.Drawing.Size(176, 20);
            this.textBox_ImageOneHEX.TabIndex = 12;
            // 
            // label_imageOneName
            // 
            this.label_imageOneName.AutoSize = true;
            this.label_imageOneName.Location = new System.Drawing.Point(6, 363);
            this.label_imageOneName.Name = "label_imageOneName";
            this.label_imageOneName.Size = new System.Drawing.Size(0, 13);
            this.label_imageOneName.TabIndex = 10;
            this.label_imageOneName.Visible = false;
            // 
            // textBox_ImageTwoName
            // 
            this.textBox_ImageTwoName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ImageTwoName.Location = new System.Drawing.Point(415, 360);
            this.textBox_ImageTwoName.Name = "textBox_ImageTwoName";
            this.textBox_ImageTwoName.Size = new System.Drawing.Size(213, 20);
            this.textBox_ImageTwoName.TabIndex = 9;
            this.textBox_ImageTwoName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBox_ImageTwoName_MouseDoubleClick);
            // 
            // textBox_ImageOneName
            // 
            this.textBox_ImageOneName.Location = new System.Drawing.Point(6, 360);
            this.textBox_ImageOneName.Name = "textBox_ImageOneName";
            this.textBox_ImageOneName.Size = new System.Drawing.Size(213, 20);
            this.textBox_ImageOneName.TabIndex = 8;
            this.textBox_ImageOneName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBox_ImageOneName_MouseDoubleClick);
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_result.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label_result.Location = new System.Drawing.Point(237, 98);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(156, 29);
            this.label_result.TabIndex = 7;
            this.label_result.Text = "Сравнение...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(257, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Результат:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox3.ImageLocation = "";
            this.pictureBox3.Location = new System.Drawing.Point(415, 45);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(213, 309);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.WaitOnLoad = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "image (*.jpg; *.png)|*.jpg; *png|All (*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 711);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_progressView.ResumeLayout(false);
            this.panel_progressView.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel_buttons.ResumeLayout(false);
            this.panel_ImagesHEX.ResumeLayout(false);
            this.panel_ImagesHEX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_FolderOfImages;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckedListBox checkedListBox_ImagesClearName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_OriginalImageFileName;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_ImageTwoName;
        private System.Windows.Forms.TextBox textBox_ImageOneName;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label label_HammingLength;
        private System.Windows.Forms.TextBox textBox_ImageTwoHEX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_ImageOneHEX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Label label_imageOneName;
        private System.Windows.Forms.Panel panel_ImagesHEX;
        private System.Windows.Forms.CheckBox checkBox_VisualImage;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxVisibleHexOfImage;
        private System.Windows.Forms.Panel panel_buttons;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel_progressView;
        private System.Windows.Forms.Label label_progress;
    }
}