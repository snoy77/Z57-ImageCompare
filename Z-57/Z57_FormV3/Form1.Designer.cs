namespace Z57_FormV3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button_start = new System.Windows.Forms.Button();
            this.textBox_sourceFolder = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_stop = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_progressFindesDublicats = new System.Windows.Forms.Label();
            this.label_ProgressSteps = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label_NumberSelectedImages = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkedListBox_imagesInFolder = new System.Windows.Forms.CheckedListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_ControllersForSourceImageName = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_TaskCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_PathToDublicatsFolder = new System.Windows.Forms.TextBox();
            this.textBox_dublicatsFolderName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_HummingsLenForDublicat = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_ControllersForSourceImageName.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(9, 34);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(160, 49);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "Начать";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // textBox_sourceFolder
            // 
            this.textBox_sourceFolder.Location = new System.Drawing.Point(9, 8);
            this.textBox_sourceFolder.Name = "textBox_sourceFolder";
            this.textBox_sourceFolder.Size = new System.Drawing.Size(331, 20);
            this.textBox_sourceFolder.TabIndex = 2;
            this.textBox_sourceFolder.TextChanged += new System.EventHandler(this.textBox_sourceFolder_TextChanged);
            this.textBox_sourceFolder.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBox_sourceFolder_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_stop);
            this.panel1.Controls.Add(this.textBox_sourceFolder);
            this.panel1.Controls.Add(this.button_start);
            this.panel1.Location = new System.Drawing.Point(5, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 86);
            this.panel1.TabIndex = 3;
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(180, 34);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(160, 49);
            this.button_stop.TabIndex = 3;
            this.button_stop.Text = "Остановить";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Visible = false;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_progressFindesDublicats);
            this.panel2.Controls.Add(this.label_ProgressSteps);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Location = new System.Drawing.Point(5, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 61);
            this.panel2.TabIndex = 4;
            // 
            // label_progressFindesDublicats
            // 
            this.label_progressFindesDublicats.AutoSize = true;
            this.label_progressFindesDublicats.Location = new System.Drawing.Point(145, 32);
            this.label_progressFindesDublicats.Name = "label_progressFindesDublicats";
            this.label_progressFindesDublicats.Size = new System.Drawing.Size(115, 13);
            this.label_progressFindesDublicats.TabIndex = 2;
            this.label_progressFindesDublicats.Text = "Найдено дубликатов:";
            // 
            // label_ProgressSteps
            // 
            this.label_ProgressSteps.AutoSize = true;
            this.label_ProgressSteps.Location = new System.Drawing.Point(9, 32);
            this.label_ProgressSteps.Name = "label_ProgressSteps";
            this.label_ProgressSteps.Size = new System.Drawing.Size(59, 13);
            this.label_ProgressSteps.TabIndex = 1;
            this.label_ProgressSteps.Text = "Сравнило:";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(9, 6);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(331, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 0;
            // 
            // label_NumberSelectedImages
            // 
            this.label_NumberSelectedImages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_NumberSelectedImages.AutoSize = true;
            this.label_NumberSelectedImages.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label_NumberSelectedImages.Location = new System.Drawing.Point(6, 21);
            this.label_NumberSelectedImages.Name = "label_NumberSelectedImages";
            this.label_NumberSelectedImages.Size = new System.Drawing.Size(137, 13);
            this.label_NumberSelectedImages.TabIndex = 5;
            this.label_NumberSelectedImages.Text = "Количество изображений";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(7, 169);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(348, 589);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label_NumberSelectedImages);
            this.tabPage1.Controls.Add(this.checkedListBox_imagesInFolder);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(340, 563);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkedListBox_imagesInFolder
            // 
            this.checkedListBox_imagesInFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkedListBox_imagesInFolder.FormattingEnabled = true;
            this.checkedListBox_imagesInFolder.Location = new System.Drawing.Point(4, 37);
            this.checkedListBox_imagesInFolder.Name = "checkedListBox_imagesInFolder";
            this.checkedListBox_imagesInFolder.Size = new System.Drawing.Size(330, 514);
            this.checkedListBox_imagesInFolder.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(340, 563);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Настройки работы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.checkBox1);
            this.panel4.Location = new System.Drawing.Point(6, 123);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(328, 90);
            this.panel4.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "При обнаружении дубликата:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(26, 28);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(258, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Автоматически выносить в папку дубликатов";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel_ControllersForSourceImageName);
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Location = new System.Drawing.Point(6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(328, 115);
            this.panel3.TabIndex = 0;
            // 
            // panel_ControllersForSourceImageName
            // 
            this.panel_ControllersForSourceImageName.Controls.Add(this.textBox2);
            this.panel_ControllersForSourceImageName.Controls.Add(this.label4);
            this.panel_ControllersForSourceImageName.Location = new System.Drawing.Point(3, 61);
            this.panel_ControllersForSourceImageName.Name = "panel_ControllersForSourceImageName";
            this.panel_ControllersForSourceImageName.Size = new System.Drawing.Size(322, 50);
            this.panel_ControllersForSourceImageName.TabIndex = 6;
            this.panel_ControllersForSourceImageName.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(19, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(296, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Исходное изображение:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 38);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(296, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "Найти из списка  дубликаты исходного изображения";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 15);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(182, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Найти все дубликаты в списке";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.textBox_TaskCount);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.textBox_PathToDublicatsFolder);
            this.tabPage3.Controls.Add(this.textBox_dublicatsFolderName);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.textBox_HummingsLenForDublicat);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(340, 563);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Настройки программы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Количество потоков:";
            // 
            // textBox_TaskCount
            // 
            this.textBox_TaskCount.Location = new System.Drawing.Point(134, 87);
            this.textBox_TaskCount.MaxLength = 3;
            this.textBox_TaskCount.Name = "textBox_TaskCount";
            this.textBox_TaskCount.Size = new System.Drawing.Size(200, 20);
            this.textBox_TaskCount.TabIndex = 6;
            this.textBox_TaskCount.Text = "3";
            this.textBox_TaskCount.TextChanged += new System.EventHandler(this.textBox_TaskCount_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Расположение папки дубликатов";
            // 
            // textBox_PathToDublicatsFolder
            // 
            this.textBox_PathToDublicatsFolder.Location = new System.Drawing.Point(197, 61);
            this.textBox_PathToDublicatsFolder.Name = "textBox_PathToDublicatsFolder";
            this.textBox_PathToDublicatsFolder.Size = new System.Drawing.Size(137, 20);
            this.textBox_PathToDublicatsFolder.TabIndex = 4;
            this.textBox_PathToDublicatsFolder.TextChanged += new System.EventHandler(this.textBox_PathToDublicatsFolder_TextChanged);
            this.textBox_PathToDublicatsFolder.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBox_PathToDublicatsFolder_MouseDoubleClick);
            // 
            // textBox_dublicatsFolderName
            // 
            this.textBox_dublicatsFolderName.Location = new System.Drawing.Point(167, 35);
            this.textBox_dublicatsFolderName.Name = "textBox_dublicatsFolderName";
            this.textBox_dublicatsFolderName.Size = new System.Drawing.Size(167, 20);
            this.textBox_dublicatsFolderName.TabIndex = 3;
            this.textBox_dublicatsFolderName.Text = "Z57_Dublicats";
            this.textBox_dublicatsFolderName.TextChanged += new System.EventHandler(this.textBox_dublicatsFolderName_TextChanged);
            this.textBox_dublicatsFolderName.Leave += new System.EventHandler(this.textBox_dublicatsFolderName_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название папки дубликатов";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Расстояние Хаминга дял дубликата от 0 до ";
            // 
            // textBox_HummingsLenForDublicat
            // 
            this.textBox_HummingsLenForDublicat.Location = new System.Drawing.Point(244, 10);
            this.textBox_HummingsLenForDublicat.Name = "textBox_HummingsLenForDublicat";
            this.textBox_HummingsLenForDublicat.Size = new System.Drawing.Size(90, 20);
            this.textBox_HummingsLenForDublicat.TabIndex = 0;
            this.textBox_HummingsLenForDublicat.Text = "15";
            this.textBox_HummingsLenForDublicat.TextChanged += new System.EventHandler(this.textBox_HummingsLenForDublicat_TextChanged);
            this.textBox_HummingsLenForDublicat.Leave += new System.EventHandler(this.textBox_HummingsLenForDublicat_Leave);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Выберите папку, в которой находятся изображения для сравнения";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(397, 12);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(397, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(80, 212);
            this.listBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 770);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel_ControllersForSourceImageName.ResumeLayout(false);
            this.panel_ControllersForSourceImageName.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.TextBox textBox_sourceFolder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_NumberSelectedImages;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckedListBox checkedListBox_imagesInFolder;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox_HummingsLenForDublicat;
        private System.Windows.Forms.Label label_progressFindesDublicats;
        private System.Windows.Forms.Label label_ProgressSteps;
        private System.Windows.Forms.Panel panel_ControllersForSourceImageName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_PathToDublicatsFolder;
        private System.Windows.Forms.TextBox textBox_dublicatsFolderName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_TaskCount;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ListBox listBox1;
    }
}

