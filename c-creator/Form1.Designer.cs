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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgrammToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_xls_start
            // 
            this.listBox_xls_start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox_xls_start.FormattingEnabled = true;
            this.listBox_xls_start.HorizontalScrollbar = true;
            this.listBox_xls_start.Location = new System.Drawing.Point(12, 62);
            this.listBox_xls_start.Name = "listBox_xls_start";
            this.listBox_xls_start.Size = new System.Drawing.Size(426, 576);
            this.listBox_xls_start.TabIndex = 0;
            this.listBox_xls_start.SelectedIndexChanged += new System.EventHandler(this.listBox_xls_start_SelectedIndexChanged);
            // 
            // button_open_file
            // 
            this.button_open_file.Location = new System.Drawing.Point(12, 26);
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
            this.listBox_db_start.Location = new System.Drawing.Point(1143, 62);
            this.listBox_db_start.Name = "listBox_db_start";
            this.listBox_db_start.Size = new System.Drawing.Size(201, 576);
            this.listBox_db_start.TabIndex = 2;
            this.listBox_db_start.SelectedIndexChanged += new System.EventHandler(this.listBox_db_start_SelectedIndexChanged);
            // 
            // listBox_xls_finish
            // 
            this.listBox_xls_finish.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_xls_finish.FormattingEnabled = true;
            this.listBox_xls_finish.HorizontalScrollbar = true;
            this.listBox_xls_finish.Location = new System.Drawing.Point(462, 62);
            this.listBox_xls_finish.Name = "listBox_xls_finish";
            this.listBox_xls_finish.Size = new System.Drawing.Size(329, 576);
            this.listBox_xls_finish.TabIndex = 3;
            this.listBox_xls_finish.SelectedIndexChanged += new System.EventHandler(this.listBox_xls_finish_SelectedIndexChanged);
            // 
            // listBox_db_finish
            // 
            this.listBox_db_finish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_db_finish.FormattingEnabled = true;
            this.listBox_db_finish.Location = new System.Drawing.Point(815, 62);
            this.listBox_db_finish.Name = "listBox_db_finish";
            this.listBox_db_finish.Size = new System.Drawing.Size(303, 576);
            this.listBox_db_finish.TabIndex = 4;
            this.listBox_db_finish.SelectedIndexChanged += new System.EventHandler(this.listBox_db_finish_SelectedIndexChanged_1);
            // 
            // comboBox_table
            // 
            this.comboBox_table.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_table.FormattingEnabled = true;
            this.comboBox_table.Location = new System.Drawing.Point(1143, 29);
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
            this.button_create_ctrl.Location = new System.Drawing.Point(462, 27);
            this.button_create_ctrl.Name = "button_create_ctrl";
            this.button_create_ctrl.Size = new System.Drawing.Size(656, 23);
            this.button_create_ctrl.TabIndex = 6;
            this.button_create_ctrl.Text = "Create control";
            this.button_create_ctrl.UseVisualStyleBackColor = true;
            this.button_create_ctrl.Click += new System.EventHandler(this.button_create_ctrl_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1359, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripSeparator2,
            this.settingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItem3.Text = "Clear All";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(115, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(115, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItem2.Text = "Exit";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutProgrammToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutProgrammToolStripMenuItem
            // 
            this.aboutProgrammToolStripMenuItem.Name = "aboutProgrammToolStripMenuItem";
            this.aboutProgrammToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.aboutProgrammToolStripMenuItem.Text = "About programm";
            // 
            // Ctrl_creator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 673);
            this.Controls.Add(this.button_create_ctrl);
            this.Controls.Add(this.comboBox_table);
            this.Controls.Add(this.listBox_db_finish);
            this.Controls.Add(this.listBox_xls_finish);
            this.Controls.Add(this.listBox_db_start);
            this.Controls.Add(this.button_open_file);
            this.Controls.Add(this.listBox_xls_start);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Ctrl_creator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control creator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_xls_start;
        private System.Windows.Forms.Button button_open_file;
        private System.Windows.Forms.ListBox listBox_db_start;
        private System.Windows.Forms.ListBox listBox_xls_finish;
        private System.Windows.Forms.ListBox listBox_db_finish;
        private System.Windows.Forms.ComboBox comboBox_table;
        private System.Windows.Forms.Button button_create_ctrl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgrammToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

