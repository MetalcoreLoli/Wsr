namespace Shindows.Forms
{
    partial class MenuForm
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
            this.DriverListForm = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.AddCarForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DriverListForm
            // 
            this.DriverListForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.DriverListForm.Location = new System.Drawing.Point(32, 134);
            this.DriverListForm.Name = "DriverListForm";
            this.DriverListForm.Size = new System.Drawing.Size(193, 41);
            this.DriverListForm.TabIndex = 0;
            this.DriverListForm.Text = "Список водителей";
            this.DriverListForm.UseVisualStyleBackColor = true;
            this.DriverListForm.Click += new System.EventHandler(this.DriverListForm_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.BackButton.Location = new System.Drawing.Point(32, 334);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(193, 41);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AddCarForm
            // 
            this.AddCarForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.AddCarForm.Location = new System.Drawing.Point(32, 193);
            this.AddCarForm.Name = "AddCarForm";
            this.AddCarForm.Size = new System.Drawing.Size(193, 41);
            this.AddCarForm.TabIndex = 2;
            this.AddCarForm.Text = "Добавлени машины";
            this.AddCarForm.UseVisualStyleBackColor = true;
            this.AddCarForm.Click += new System.EventHandler(this.AddCarForm_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 387);
            this.Controls.Add(this.AddCarForm);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.DriverListForm);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DriverListForm;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button AddCarForm;
    }
}