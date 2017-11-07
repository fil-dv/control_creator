using c_creator.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_creator.SettingsForm
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            InitControls();
        }

        void InitControls()
        {
            numericUpDown_excel_rows.Value = Settings.RowCount;
            textBox_file_name.Text = Settings.CtrlFileName;
            numericUpDown_comment_number.Value = Settings.CommentStart;
            checkBox_is_reg.Checked = Settings.IsRegister;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.RowCount = (int)numericUpDown_excel_rows.Value;
                Settings.CtrlFileName = textBox_file_name.Text;
                Settings.CommentStart = (int)numericUpDown_comment_number.Value;
                Settings.IsRegister = checkBox_is_reg.Checked;
                this.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
