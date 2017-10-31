using c_creator.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_creator
{
    public partial class Ctrl_creator : Form
    {
        public Ctrl_creator()
        {
            InitializeComponent();

        }

        private void button_open_file_Click(object sender, EventArgs e)
        {
            using (var selectFileDialog = new OpenFileDialog())
            {
                selectFileDialog.Filter = "Excel Files|*.xls;*.xlsx;";
                if (selectFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //listBox_xls.Items.Add(selectFileDialog.FileName);
                    ExcelReader reader = new ExcelReader(this, selectFileDialog.FileName);
                    reader.Read();
                }
            }
        }
    }
}
