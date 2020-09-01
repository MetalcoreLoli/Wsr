namespace Shindows.Forms
{
    partial class LicenceForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.MiddleName = new System.Windows.Forms.TextBox();
            this.RegionWithCityBox = new System.Windows.Forms.TextBox();
            this.BirthDateBox = new System.Windows.Forms.DateTimePicker();
            this.WhereWasTakeBox = new System.Windows.Forms.TextBox();
            this.LicenceNumberBox = new System.Windows.Forms.TextBox();
            this.CategoriesBox = new System.Windows.Forms.ComboBox();
            this.CategoryBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PhotoBox = new System.Windows.Forms.PictureBox();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SerialBox = new System.Windows.Forms.TextBox();
            this.AddCatButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Shindows.Properties.Resources.driver_license_template;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(816, 491);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LastNameBox
            // 
            this.LastNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameBox.Location = new System.Drawing.Point(245, 187);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.ReadOnly = true;
            this.LastNameBox.Size = new System.Drawing.Size(143, 24);
            this.LastNameBox.TabIndex = 1;
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBox.Location = new System.Drawing.Point(245, 217);
            this.NameBox.Name = "NameBox";
            this.NameBox.ReadOnly = true;
            this.NameBox.Size = new System.Drawing.Size(143, 24);
            this.NameBox.TabIndex = 2;
            // 
            // MiddleName
            // 
            this.MiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MiddleName.Location = new System.Drawing.Point(394, 217);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.ReadOnly = true;
            this.MiddleName.Size = new System.Drawing.Size(143, 24);
            this.MiddleName.TabIndex = 3;
            // 
            // RegionWithCityBox
            // 
            this.RegionWithCityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegionWithCityBox.Location = new System.Drawing.Point(245, 280);
            this.RegionWithCityBox.Name = "RegionWithCityBox";
            this.RegionWithCityBox.Size = new System.Drawing.Size(143, 24);
            this.RegionWithCityBox.TabIndex = 5;
            // 
            // BirthDateBox
            // 
            this.BirthDateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.BirthDateBox.Location = new System.Drawing.Point(245, 250);
            this.BirthDateBox.Name = "BirthDateBox";
            this.BirthDateBox.Size = new System.Drawing.Size(143, 24);
            this.BirthDateBox.TabIndex = 6;
            // 
            // WhereWasTakeBox
            // 
            this.WhereWasTakeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WhereWasTakeBox.Location = new System.Drawing.Point(245, 310);
            this.WhereWasTakeBox.Name = "WhereWasTakeBox";
            this.WhereWasTakeBox.Size = new System.Drawing.Size(143, 24);
            this.WhereWasTakeBox.TabIndex = 7;
            // 
            // LicenceNumberBox
            // 
            this.LicenceNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LicenceNumberBox.Location = new System.Drawing.Point(394, 340);
            this.LicenceNumberBox.Name = "LicenceNumberBox";
            this.LicenceNumberBox.ReadOnly = true;
            this.LicenceNumberBox.Size = new System.Drawing.Size(143, 24);
            this.LicenceNumberBox.TabIndex = 8;
            // 
            // CategoriesBox
            // 
            this.CategoriesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CategoriesBox.FormattingEnabled = true;
            this.CategoriesBox.Location = new System.Drawing.Point(394, 369);
            this.CategoriesBox.Name = "CategoriesBox";
            this.CategoriesBox.Size = new System.Drawing.Size(143, 26);
            this.CategoriesBox.TabIndex = 9;
            // 
            // CategoryBox
            // 
            this.CategoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryBox.Location = new System.Drawing.Point(245, 371);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(143, 24);
            this.CategoryBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(394, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Фамилия (Surename)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(552, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Имя(Name), Отчество(MIddle Name)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(394, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Дата рождения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(391, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Где выдали (город(city), регион(region))";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(391, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Где выдали (Отдел)";
            // 
            // PhotoBox
            // 
            this.PhotoBox.Location = new System.Drawing.Point(63, 173);
            this.PhotoBox.Name = "PhotoBox";
            this.PhotoBox.Size = new System.Drawing.Size(141, 191);
            this.PhotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PhotoBox.TabIndex = 16;
            this.PhotoBox.TabStop = false;
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.RegistrationButton.Location = new System.Drawing.Point(150, 428);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(186, 34);
            this.RegistrationButton.TabIndex = 17;
            this.RegistrationButton.Text = "Зарегистрировать";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button2.Location = new System.Drawing.Point(489, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 34);
            this.button2.TabIndex = 18;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SerialBox
            // 
            this.SerialBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SerialBox.Location = new System.Drawing.Point(245, 340);
            this.SerialBox.Name = "SerialBox";
            this.SerialBox.ReadOnly = true;
            this.SerialBox.Size = new System.Drawing.Size(143, 24);
            this.SerialBox.TabIndex = 19;
            // 
            // AddCatButton
            // 
            this.AddCatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.AddCatButton.Location = new System.Drawing.Point(543, 369);
            this.AddCatButton.Name = "AddCatButton";
            this.AddCatButton.Size = new System.Drawing.Size(165, 34);
            this.AddCatButton.TabIndex = 20;
            this.AddCatButton.Text = "Добавить категорию";
            this.AddCatButton.UseVisualStyleBackColor = true;
            this.AddCatButton.Click += new System.EventHandler(this.AddCatButton_Click);
            // 
            // LicenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 491);
            this.Controls.Add(this.AddCatButton);
            this.Controls.Add(this.SerialBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.PhotoBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CategoryBox);
            this.Controls.Add(this.CategoriesBox);
            this.Controls.Add(this.LicenceNumberBox);
            this.Controls.Add(this.WhereWasTakeBox);
            this.Controls.Add(this.BirthDateBox);
            this.Controls.Add(this.RegionWithCityBox);
            this.Controls.Add(this.MiddleName);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LicenceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма регистрации фодительского удостоверения";
            this.Load += new System.EventHandler(this.LicenceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox MiddleName;
        private System.Windows.Forms.TextBox RegionWithCityBox;
        private System.Windows.Forms.DateTimePicker BirthDateBox;
        private System.Windows.Forms.TextBox WhereWasTakeBox;
        private System.Windows.Forms.TextBox LicenceNumberBox;
        private System.Windows.Forms.ComboBox CategoriesBox;
        private System.Windows.Forms.TextBox CategoryBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox PhotoBox;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox SerialBox;
        private System.Windows.Forms.Button AddCatButton;
    }
}