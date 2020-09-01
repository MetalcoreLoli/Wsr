namespace Shindows.Forms
{
    partial class LicenceListForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StatusBox = new System.Windows.Forms.ComboBox();
            this.CleanFilltersButton = new System.Windows.Forms.Button();
            this.ApplyFilltersButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LastNameBox = new System.Windows.Forms.ComboBox();
            this.MiddleNameBox = new System.Windows.Forms.ComboBox();
            this.NameBox = new System.Windows.Forms.ComboBox();
            this.DriversListGrid = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DriversListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.StatusBox);
            this.groupBox1.Controls.Add(this.CleanFilltersButton);
            this.groupBox1.Controls.Add(this.ApplyFilltersButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LastNameBox);
            this.groupBox1.Controls.Add(this.MiddleNameBox);
            this.groupBox1.Controls.Add(this.NameBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBox1.Location = new System.Drawing.Point(642, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 425);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтры";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(56, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Статус";
            // 
            // StatusBox
            // 
            this.StatusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.StatusBox.FormattingEnabled = true;
            this.StatusBox.Location = new System.Drawing.Point(15, 246);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(145, 28);
            this.StatusBox.TabIndex = 29;
            // 
            // CleanFilltersButton
            // 
            this.CleanFilltersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CleanFilltersButton.Location = new System.Drawing.Point(28, 384);
            this.CleanFilltersButton.Name = "CleanFilltersButton";
            this.CleanFilltersButton.Size = new System.Drawing.Size(122, 34);
            this.CleanFilltersButton.TabIndex = 28;
            this.CleanFilltersButton.Text = "Очистить";
            this.CleanFilltersButton.UseVisualStyleBackColor = true;
            this.CleanFilltersButton.Click += new System.EventHandler(this.CleanFilltersButton_Click);
            // 
            // ApplyFilltersButton
            // 
            this.ApplyFilltersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ApplyFilltersButton.Location = new System.Drawing.Point(28, 343);
            this.ApplyFilltersButton.Name = "ApplyFilltersButton";
            this.ApplyFilltersButton.Size = new System.Drawing.Size(122, 34);
            this.ApplyFilltersButton.TabIndex = 24;
            this.ApplyFilltersButton.Text = "Применить";
            this.ApplyFilltersButton.UseVisualStyleBackColor = true;
            this.ApplyFilltersButton.Click += new System.EventHandler(this.ApplyFilltersButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(41, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(45, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(56, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Имя";
            // 
            // LastNameBox
            // 
            this.LastNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LastNameBox.FormattingEnabled = true;
            this.LastNameBox.Location = new System.Drawing.Point(15, 184);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(145, 28);
            this.LastNameBox.TabIndex = 24;
            // 
            // MiddleNameBox
            // 
            this.MiddleNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.MiddleNameBox.FormattingEnabled = true;
            this.MiddleNameBox.Location = new System.Drawing.Point(15, 124);
            this.MiddleNameBox.Name = "MiddleNameBox";
            this.MiddleNameBox.Size = new System.Drawing.Size(145, 28);
            this.MiddleNameBox.TabIndex = 23;
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.NameBox.FormattingEnabled = true;
            this.NameBox.Location = new System.Drawing.Point(15, 63);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(145, 28);
            this.NameBox.TabIndex = 22;
            // 
            // DriversListGrid
            // 
            this.DriversListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DriversListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.SerialColumn,
            this.NumberColumn,
            this.NameColumn,
            this.MiddleNameColumn,
            this.LastNameColumn,
            this.PhoneColumn,
            this.EmailColumn,
            this.StatusColumn});
            this.DriversListGrid.Location = new System.Drawing.Point(0, 1);
            this.DriversListGrid.MultiSelect = false;
            this.DriversListGrid.Name = "DriversListGrid";
            this.DriversListGrid.ReadOnly = true;
            this.DriversListGrid.Size = new System.Drawing.Size(636, 436);
            this.DriversListGrid.TabIndex = 25;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.BackButton.Location = new System.Drawing.Point(245, 454);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(186, 34);
            this.BackButton.TabIndex = 24;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            // 
            // SerialColumn
            // 
            this.SerialColumn.HeaderText = "Серия";
            this.SerialColumn.Name = "SerialColumn";
            this.SerialColumn.ReadOnly = true;
            // 
            // NumberColumn
            // 
            this.NumberColumn.HeaderText = "Номер";
            this.NumberColumn.Name = "NumberColumn";
            this.NumberColumn.ReadOnly = true;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Имя";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // MiddleNameColumn
            // 
            this.MiddleNameColumn.HeaderText = "Фамилия";
            this.MiddleNameColumn.Name = "MiddleNameColumn";
            this.MiddleNameColumn.ReadOnly = true;
            // 
            // LastNameColumn
            // 
            this.LastNameColumn.HeaderText = "Отчество";
            this.LastNameColumn.Name = "LastNameColumn";
            this.LastNameColumn.ReadOnly = true;
            // 
            // PhoneColumn
            // 
            this.PhoneColumn.HeaderText = "Телефон";
            this.PhoneColumn.Name = "PhoneColumn";
            this.PhoneColumn.ReadOnly = true;
            // 
            // EmailColumn
            // 
            this.EmailColumn.HeaderText = "Email";
            this.EmailColumn.Name = "EmailColumn";
            this.EmailColumn.ReadOnly = true;
            // 
            // StatusColumn
            // 
            this.StatusColumn.HeaderText = "Статус";
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.ReadOnly = true;
            // 
            // LicenceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 509);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DriversListGrid);
            this.Controls.Add(this.BackButton);
            this.Name = "LicenceListForm";
            this.Text = "LicenceListForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DriversListGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CleanFilltersButton;
        private System.Windows.Forms.Button ApplyFilltersButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox LastNameBox;
        private System.Windows.Forms.ComboBox MiddleNameBox;
        private System.Windows.Forms.ComboBox NameBox;
        private System.Windows.Forms.DataGridView DriversListGrid;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox StatusBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
    }
}