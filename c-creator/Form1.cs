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
            InitCombo();
        }

        private void button_open_file_Click(object sender, EventArgs e)
        {
            using (var selectFileDialog = new OpenFileDialog())
            {
                selectFileDialog.Filter = "Excel Files|*.xls;*.xlsx;";
                if (selectFileDialog.ShowDialog() == DialogResult.OK)
                {                    
                    ExcelReader reader = new ExcelReader(this, selectFileDialog.FileName);
                    reader.Read();
                    InsertXlsToListBox();                    
                }
            }
        }

        void InitCombo()
        {
            comboBox_table.Items.Add("Import_clnt_example");
            comboBox_table.Items.Add("Import_update_comisiya");
            comboBox_table.SelectedIndex = 0;
        }

        void InsertDbTableCulumns(string fileName)
        {
            List<string> columnList = TextFileReader.ReadTextFile(@"..\..\text\" + fileName);
            int counter = 0;
            foreach (var item in columnList)
            {
                listBox_db_start.Items.Add(item);
            }
        }

        void InsertXlsToListBox()
        {
            if (Mediator.IsReady)
            {                
                for(int i = 0; i< Mediator.DataList.Count; i++)
                {
                    List<string> tempList = Mediator.DataList[i];
                    string str = (i + 1).ToString() + ") ";
                    foreach (var item in tempList)
                    {
                        str +=  item + " | ";
                    }
                    listBox_xls_start.Items.Add(str);
                }                
            }            
        }

        private void listBox_xls_start_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_table_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_db_start.Items.Clear();
            switch (comboBox_table.SelectedIndex)
            {
                case 0:
                    InsertDbTableCulumns("ice.txt");
                    break;
                case 1:
                    InsertDbTableCulumns("iuc.txt");
                    break;
                default:
                    InsertDbTableCulumns("ice.txt");
                    break;
            }
        }
    }
}
