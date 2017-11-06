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
            this.listBox_xls_start = new System.Windows.Forms.ListBox();
            this.button_open_file = new System.Windows.Forms.Button();
            this.listBox_db_start = new System.Windows.Forms.ListBox();
            this.listBox_xls_finish = new System.Windows.Forms.ListBox();
            this.listBox_db_finish = new System.Windows.Forms.ListBox();
            this.comboBox_table = new System.Windows.Forms.ComboBox();
            this.button_create_ctrl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_xls_start
            // 
            this.listBox_xls_start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox_xls_start.FormattingEnabled = true;
            this.listBox_xls_start.HorizontalScrollbar = true;
            this.listBox_xls_start.Location = new System.Drawing.Point(12, 42);
            this.listBox_xls_start.Name = "listBox_xls_start";
            this.listBox_xls_start.Size = new System.Drawing.Size(426, 563);
            this.listBox_xls_start.TabIndex = 0;
            this.listBox_xls_start.SelectedIndexChanged += new System.EventHandler(this.listBox_xls_start_SelectedIndexChanged);
            // 
            // button_open_file
            // 
            this.button_open_file.Location = new System.Drawing.Point(12, 12);
            this.button_open_file.Name = "button_open_file";
            this.button_open_file.Size = new System.Drawing.Size(426, 23);
            this.button_open_file.TabIndex = 1;
            this.button_open_file.Text = "Open file";
            this.button_open_file.UseVisualStyleBackColor = true;
            this.button_open_file.Click += new System.EventHandler(this.button_open_file_Click);
            // 
            // listBox_db_start
            // 
            this.listBox_db_start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_db_start.FormattingEnabled = true;
            this.listBox_db_start.Location = new System.Drawing.Point(908, 42);
            this.listBox_db_start.Name = "listBox_db_start";
            this.listBox_db_start.Size = new System.Drawing.Size(201, 563);
            this.listBox_db_start.TabIndex = 2;
            this.listBox_db_start.SelectedIndexChanged += new System.EventHandler(this.listBox_db_start_SelectedIndexChanged);
            // 
            // listBox_xls_finish
            // 
            this.listBox_xls_finish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox_xls_finish.FormattingEnabled = true;
            this.listBox_xls_finish.HorizontalScrollbar = true;
            this.listBox_xls_finish.Location = new System.Drawing.Point(462, 42);
            this.listBox_xls_finish.Name = "listBox_xls_finish";
            this.listBox_xls_finish.Size = new System.Drawing.Size(263, 563);
            this.listBox_xls_finish.TabIndex = 3;
            this.listBox_xls_finish.SelectedIndexChanged += new System.EventHandler(this.listBox_xls_finish_SelectedIndexChanged);
            // 
            // listBox_db_finish
            // 
            this.listBox_db_finish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_db_finish.FormattingEnabled = true;
            this.listBox_db_finish.Location = new System.Drawing.Point(749, 42);
            this.listBox_db_finish.Name = "listBox_db_finish";
            this.listBox_db_finish.Size = new System.Drawing.Size(134, 563);
            this.listBox_db_finish.TabIndex = 4;
            this.listBox_db_finish.SelectedIndexChanged += new System.EventHandler(this.listBox_db_finish_SelectedIndexChanged_1);
            // 
            // comboBox_table
            // 
            this.comboBox_table.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_table.FormattingEnabled = true;
            this.comboBox_table.Location = new System.Drawing.Point(908, 15);
            this.comboBox_table.Name = "comboBox_table";
            this.comboBox_table.Size = new System.Drawing.Size(201, 21);
            this.comboBox_table.TabIndex = 5;
            this.comboBox_table.SelectedIndexChanged += new System.EventHandler(this.comboBox_table_SelectedIndexChanged);
            // 
            // button_create_ctrl
            // 
            this.button_create_ctrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_create_ctrl.Enabled = false;
            this.button_create_ctrl.Location = new System.Drawing.Point(462, 13);
            this.button_create_ctrl.Name = "button_create_ctrl";
            this.button_create_ctrl.Size = new System.Drawing.Size(421, 23);
            this.button_create_ctrl.TabIndex = 6;
            this.button_create_ctrl.Text = "Create control";
            this.button_create_ctrl.UseVisualStyleBackColor = true;
            this.button_create_ctrl.Click += new System.EventHandler(this.button_create_ctrl_Click);
            // 
            // Ctrl_creator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 637);
            this.Controls.Add(this.button_create_ctrl);
            this.Controls.Add(this.comboBox_table);
            this.Controls.Add(this.listBox_db_finish);
            this.Controls.Add(this.listBox_xls_finish);
            this.Controls.Add(this.listBox_db_start);
            this.Controls.Add(this.button_open_file);
            this.Controls.Add(this.listBox_xls_start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ctrl_creator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control creator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_xls_start;
        private System.Windows.Forms.Button button_open_file;
        private System.Windows.Forms.ListBox listBox_db_start;
        private System.Windows.Forms.ListBox listBox_xls_finish;
        private System.Windows.Forms.ListBox listBox_db_finish;
        private System.Windows.Forms.ComboBox comboBox_table;
        private System.Windows.Forms.Button button_create_ctrl;
    }
}

