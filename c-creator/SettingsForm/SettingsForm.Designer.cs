namespace c_creator.SettingsForm
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.checkBox_is_reg = new System.Windows.Forms.CheckBox();
            this.numericUpDown_excel_rows = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_file_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_comment_number = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_excel_rows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_comment_number)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox_is_reg
            // 
            this.checkBox_is_reg.AutoSize = true;
            this.checkBox_is_reg.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_is_reg.Checked = true;
            this.checkBox_is_reg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_is_reg.Location = new System.Drawing.Point(376, 170);
            this.checkBox_is_reg.Name = "checkBox_is_reg";
            this.checkBox_is_reg.Size = new System.Drawing.Size(15, 14);
            this.checkBox_is_reg.TabIndex = 0;
            this.checkBox_is_reg.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_excel_rows
            // 
            this.numericUpDown_excel_rows.Location = new System.Drawing.Point(348, 25);
            this.numericUpDown_excel_rows.Name = "numericUpDown_excel_rows";
            this.numericUpDown_excel_rows.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown_excel_rows.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сколько строк читаем из Excel:";
            // 
            // textBox_file_name
            // 
            this.textBox_file_name.Location = new System.Drawing.Point(294, 70);
            this.textBox_file_name.Name = "textBox_file_name";
            this.textBox_file_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_file_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя выходного файла: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Начиная какого номера используем комменты для \"мусора\":";
            // 
            // numericUpDown_comment_number
            // 
            this.numericUpDown_comment_number.Location = new System.Drawing.Point(348, 123);
            this.numericUpDown_comment_number.Name = "numericUpDown_comment_number";
            this.numericUpDown_comment_number.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown_comment_number.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Это реестр (добавляет в конце поле \"END_OF_REG\"):";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(319, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Ok";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 260);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_comment_number);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_file_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_excel_rows);
            this.Controls.Add(this.checkBox_is_reg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_excel_rows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_comment_number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_is_reg;
        private System.Windows.Forms.NumericUpDown numericUpDown_excel_rows;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_file_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_comment_number;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}