namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.countFile = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ZIPButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ZipTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DestinationTextBox = new System.Windows.Forms.TextBox();
            this.AddPasswordButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.IsPassword = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BrowserTextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.SelectedFileList = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(687, 542);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Parkhomenko Victoria | .Net C# Project ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(26, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(927, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.countFile);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Controls.Add(this.ZIPButton);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BrowserTextBox);
            this.groupBox1.Controls.Add(this.BrowseButton);
            this.groupBox1.Controls.Add(this.SelectedFileList);
            this.groupBox1.Location = new System.Drawing.Point(27, 116);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(926, 422);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Кількість обраних файлів:";
            // 
            // countFile
            // 
            this.countFile.AutoSize = true;
            this.countFile.Location = new System.Drawing.Point(208, 241);
            this.countFile.Name = "countFile";
            this.countFile.Size = new System.Drawing.Size(16, 17);
            this.countFile.TabIndex = 18;
            this.countFile.Text = "0";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(831, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 48);
            this.button2.TabIndex = 17;
            this.button2.Text = "Вихід";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(742, 309);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 46);
            this.button3.TabIndex = 16;
            this.button3.Text = "Створити новий архів";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Restart_button);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(163, 334);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(48, 21);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "rar";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 309);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Оберіть розширення файлу:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(19, 334);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 21);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "zip";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Location = new System.Drawing.Point(18, 273);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(340, 28);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Видалити обраний файл зі списку";
            this.DeleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.delete_button_click);
            // 
            // ZIPButton
            // 
            this.ZIPButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ZIPButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZIPButton.Location = new System.Drawing.Point(502, 309);
            this.ZIPButton.Margin = new System.Windows.Forms.Padding(4);
            this.ZIPButton.Name = "ZIPButton";
            this.ZIPButton.Size = new System.Drawing.Size(171, 46);
            this.ZIPButton.TabIndex = 0;
            this.ZIPButton.Text = "Заархівувати";
            this.ZIPButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ZIPButton.UseVisualStyleBackColor = false;
            this.ZIPButton.Click += new System.EventHandler(this.ZIPButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ZipTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.DestinationTextBox);
            this.groupBox2.Controls.Add(this.AddPasswordButton);
            this.groupBox2.Controls.Add(this.PasswordTextBox);
            this.groupBox2.Controls.Add(this.IsPassword);
            this.groupBox2.Location = new System.Drawing.Point(502, 36);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(412, 265);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Архівація";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(21, 225);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(288, 21);
            this.checkBox3.TabIndex = 17;
            this.checkBox3.Text = "Видалити обрані файли, після архівації";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Вкажіть ім\'я нового файлу:";
            // 
            // ZipTextBox
            // 
            this.ZipTextBox.Location = new System.Drawing.Point(21, 113);
            this.ZipTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ZipTextBox.Name = "ZipTextBox";
            this.ZipTextBox.Size = new System.Drawing.Size(304, 22);
            this.ZipTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Оберіть директорію для запису нового архіву";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(339, 156);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 43);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.destination_folder_button);
            // 
            // DestinationTextBox
            // 
            this.DestinationTextBox.Enabled = false;
            this.DestinationTextBox.Location = new System.Drawing.Point(21, 177);
            this.DestinationTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DestinationTextBox.Name = "DestinationTextBox";
            this.DestinationTextBox.Size = new System.Drawing.Size(304, 22);
            this.DestinationTextBox.TabIndex = 4;
            // 
            // AddPasswordButton
            // 
            this.AddPasswordButton.BackColor = System.Drawing.SystemColors.Control;
            this.AddPasswordButton.Enabled = false;
            this.AddPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPasswordButton.Image = ((System.Drawing.Image)(resources.GetObject("AddPasswordButton.Image")));
            this.AddPasswordButton.Location = new System.Drawing.Point(339, 45);
            this.AddPasswordButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddPasswordButton.Name = "AddPasswordButton";
            this.AddPasswordButton.Size = new System.Drawing.Size(45, 34);
            this.AddPasswordButton.TabIndex = 3;
            this.AddPasswordButton.UseVisualStyleBackColor = false;
            this.AddPasswordButton.Click += new System.EventHandler(this.AddPasswordButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Enabled = false;
            this.PasswordTextBox.Location = new System.Drawing.Point(21, 57);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(304, 22);
            this.PasswordTextBox.TabIndex = 2;
            // 
            // IsPassword
            // 
            this.IsPassword.AutoSize = true;
            this.IsPassword.Location = new System.Drawing.Point(21, 28);
            this.IsPassword.Margin = new System.Windows.Forms.Padding(4);
            this.IsPassword.Name = "IsPassword";
            this.IsPassword.Size = new System.Drawing.Size(131, 21);
            this.IsPassword.TabIndex = 1;
            this.IsPassword.Text = "Додати пароль";
            this.IsPassword.UseVisualStyleBackColor = true;
            this.IsPassword.CheckedChanged += new System.EventHandler(this.check_for_password);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Оберіть бажані файли:";
            // 
            // BrowserTextBox
            // 
            this.BrowserTextBox.Enabled = false;
            this.BrowserTextBox.Location = new System.Drawing.Point(19, 55);
            this.BrowserTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.BrowserTextBox.Name = "BrowserTextBox";
            this.BrowserTextBox.Size = new System.Drawing.Size(340, 22);
            this.BrowserTextBox.TabIndex = 2;
            // 
            // BrowseButton
            // 
            this.BrowseButton.BackColor = System.Drawing.SystemColors.Control;
            this.BrowseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BrowseButton.BackgroundImage")));
            this.BrowseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseButton.Location = new System.Drawing.Point(382, 55);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(4);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(60, 42);
            this.BrowseButton.TabIndex = 1;
            this.BrowseButton.UseVisualStyleBackColor = false;
            this.BrowseButton.Click += new System.EventHandler(this.add_items_button_Click);
            // 
            // SelectedFileList
            // 
            this.SelectedFileList.FormattingEnabled = true;
            this.SelectedFileList.ItemHeight = 16;
            this.SelectedFileList.Location = new System.Drawing.Point(19, 89);
            this.SelectedFileList.Margin = new System.Windows.Forms.Padding(4);
            this.SelectedFileList.Name = "SelectedFileList";
            this.SelectedFileList.Size = new System.Drawing.Size(340, 148);
            this.SelectedFileList.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 569);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ArchiveFile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ZIPButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ZipTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox DestinationTextBox;
        private System.Windows.Forms.Button AddPasswordButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.CheckBox IsPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BrowserTextBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.ListBox SelectedFileList;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label countFile;
        private System.Windows.Forms.Label label5;
    }
}

