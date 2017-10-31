namespace c_creator
{
    partial class Ctrl_creator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ctrl_creator));
            this.listBox_xls = new System.Windows.Forms.ListBox();
            this.button_open_file = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_xls
            // 
            this.listBox_xls.FormattingEnabled = true;
            this.listBox_xls.Location = new System.Drawing.Point(12, 12);
            this.listBox_xls.Name = "listBox_xls";
            this.listBox_xls.Size = new System.Drawing.Size(133, 264);
            this.listBox_xls.TabIndex = 0;
            // 
            // button_open_file
            // 
            this.button_open_file.Location = new System.Drawing.Point(406, 253);
            this.button_open_file.Name = "button_open_file";
            this.button_open_file.Size = new System.Drawing.Size(75, 23);
            this.button_open_file.TabIndex = 1;
            this.button_open_file.Text = "Open file";
            this.button_open_file.UseVisualStyleBackColor = true;
            this.button_open_file.Click += new System.EventHandler(this.button_open_file_Click);
            // 
            // Ctrl_creator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 286);
            this.Controls.Add(this.button_open_file);
            this.Controls.Add(this.listBox_xls);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ctrl_creator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control creator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_xls;
        private System.Windows.Forms.Button button_open_file;
    }
}

