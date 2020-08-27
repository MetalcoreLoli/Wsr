namespace Shindows.Forms
{
    partial class DriverCreatingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.MIddleNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StreetBox = new System.Windows.Forms.ComboBox();
            this.PostcodeBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.HouseNumberBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PathToImageBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DesriptionBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DoneButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ImageLoadButton = new System.Windows.Forms.Button();
            this.PhoneBox = new System.Windows.Forms.MaskedTextBox();
            this.CompanyBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.JobBox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PassportNumberBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.PassportSerialBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DriverPhotoBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DriverPhotoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(15, 34);
            this.IdBox.Name = "IdBox";
            this.IdBox.ReadOnly = true;
            this.IdBox.Size = new System.Drawing.Size(148, 20);
            this.IdBox.TabIndex = 1;
            // 
            // MIddleNameBox
            // 
            this.MIddleNameBox.Location = new System.Drawing.Point(15, 72);
            this.MIddleNameBox.Name = "MIddleNameBox";
            this.MIddleNameBox.Size = new System.Drawing.Size(148, 20);
            this.MIddleNameBox.TabIndex = 3;
            this.MIddleNameBox.Text = "test";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(15, 113);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(148, 20);
            this.NameBox.TabIndex = 5;
            this.NameBox.Text = "test";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Имя";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StreetBox);
            this.groupBox1.Controls.Add(this.PostcodeBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.HouseNumberBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(15, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 170);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Адрес";
            // 
            // StreetBox
            // 
            this.StreetBox.FormattingEnabled = true;
            this.StreetBox.Location = new System.Drawing.Point(6, 42);
            this.StreetBox.Name = "StreetBox";
            this.StreetBox.Size = new System.Drawing.Size(142, 21);
            this.StreetBox.TabIndex = 14;
            // 
            // PostcodeBox
            // 
            this.PostcodeBox.Location = new System.Drawing.Point(6, 129);
            this.PostcodeBox.Name = "PostcodeBox";
            this.PostcodeBox.Size = new System.Drawing.Size(142, 20);
            this.PostcodeBox.TabIndex = 13;
            this.PostcodeBox.Text = "test";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Почтовый Идекс";
            // 
            // HouseNumberBox
            // 
            this.HouseNumberBox.Location = new System.Drawing.Point(6, 85);
            this.HouseNumberBox.Name = "HouseNumberBox";
            this.HouseNumberBox.Size = new System.Drawing.Size(142, 20);
            this.HouseNumberBox.TabIndex = 11;
            this.HouseNumberBox.Text = "test";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Номер Дома";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Улица";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Отчество";
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(15, 159);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(148, 20);
            this.LastNameBox.TabIndex = 7;
            this.LastNameBox.Text = "test";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(199, 34);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(194, 20);
            this.EmailBox.TabIndex = 10;
            this.EmailBox.Text = "test@test.test";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(196, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Email";
            // 
            // PathToImageBox
            // 
            this.PathToImageBox.Location = new System.Drawing.Point(199, 113);
            this.PathToImageBox.Name = "PathToImageBox";
            this.PathToImageBox.ReadOnly = true;
            this.PathToImageBox.Size = new System.Drawing.Size(100, 20);
            this.PathToImageBox.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(196, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Пусть до картинки";
            // 
            // DesriptionBox
            // 
            this.DesriptionBox.Location = new System.Drawing.Point(199, 253);
            this.DesriptionBox.Multiline = true;
            this.DesriptionBox.Name = "DesriptionBox";
            this.DesriptionBox.Size = new System.Drawing.Size(359, 243);
            this.DesriptionBox.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(196, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Замечание";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(196, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Номер телефона";
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(51, 515);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 23);
            this.DoneButton.TabIndex = 17;
            this.DoneButton.Text = "Добавить";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(357, 515);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 18;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ImageLoadButton
            // 
            this.ImageLoadButton.Location = new System.Drawing.Point(318, 110);
            this.ImageLoadButton.Name = "ImageLoadButton";
            this.ImageLoadButton.Size = new System.Drawing.Size(75, 23);
            this.ImageLoadButton.TabIndex = 19;
            this.ImageLoadButton.Text = "Загрузить";
            this.ImageLoadButton.UseVisualStyleBackColor = true;
            this.ImageLoadButton.Click += new System.EventHandler(this.ImageLoadButton_Click);
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(199, 74);
            this.PhoneBox.Mask = "(999) 000-0000";
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(194, 20);
            this.PhoneBox.TabIndex = 20;
            this.PhoneBox.Text = "1111111111";
            // 
            // CompanyBox
            // 
            this.CompanyBox.FormattingEnabled = true;
            this.CompanyBox.Location = new System.Drawing.Point(199, 158);
            this.CompanyBox.Name = "CompanyBox";
            this.CompanyBox.Size = new System.Drawing.Size(194, 21);
            this.CompanyBox.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(196, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Место работы";
            // 
            // JobBox
            // 
            this.JobBox.FormattingEnabled = true;
            this.JobBox.Location = new System.Drawing.Point(199, 204);
            this.JobBox.Name = "JobBox";
            this.JobBox.Size = new System.Drawing.Size(194, 21);
            this.JobBox.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(196, 188);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Должность";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PassportNumberBox);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.PassportSerialBox);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(21, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 125);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Паспорт";
            // 
            // PassportNumberBox
            // 
            this.PassportNumberBox.Location = new System.Drawing.Point(6, 88);
            this.PassportNumberBox.Name = "PassportNumberBox";
            this.PassportNumberBox.Size = new System.Drawing.Size(142, 20);
            this.PassportNumberBox.TabIndex = 13;
            this.PassportNumberBox.Text = "12345678";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Номер";
            // 
            // PassportSerialBox
            // 
            this.PassportSerialBox.Location = new System.Drawing.Point(6, 44);
            this.PassportSerialBox.Name = "PassportSerialBox";
            this.PassportSerialBox.Size = new System.Drawing.Size(142, 20);
            this.PassportSerialBox.TabIndex = 11;
            this.PassportSerialBox.Text = "1234";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Серия";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DriverPhotoBox
            // 
            this.DriverPhotoBox.Location = new System.Drawing.Point(415, 34);
            this.DriverPhotoBox.Name = "DriverPhotoBox";
            this.DriverPhotoBox.Size = new System.Drawing.Size(143, 191);
            this.DriverPhotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DriverPhotoBox.TabIndex = 26;
            this.DriverPhotoBox.TabStop = false;
            // 
            // DriverCreatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 564);
            this.Controls.Add(this.DriverPhotoBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.JobBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.CompanyBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.ImageLoadButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DesriptionBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PathToImageBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MIddleNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.label1);
            this.Name = "DriverCreatingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма создания водителя";
            this.Load += new System.EventHandler(this.DriverCreatingForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DriverPhotoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox IdBox;
        public System.Windows.Forms.TextBox MIddleNameBox;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox NameBox;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox StreetBox;
        public System.Windows.Forms.TextBox PostcodeBox;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox HouseNumberBox;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox LastNameBox;
        public System.Windows.Forms.TextBox EmailBox;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox PathToImageBox;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox DesriptionBox;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Button DoneButton;
        public System.Windows.Forms.Button BackButton;
        public System.Windows.Forms.Button ImageLoadButton;
        public System.Windows.Forms.MaskedTextBox PhoneBox;
        public System.Windows.Forms.ComboBox CompanyBox;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.ComboBox JobBox;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox PassportNumberBox;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox PassportSerialBox;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.PictureBox DriverPhotoBox;
    }
}