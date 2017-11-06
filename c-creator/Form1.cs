using c_creator.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace c_creator
{
    public partial class Ctrl_creator : Form
    {
        string _xlsFilePath;
        List<MyListViewItem> _xlsItemList_1 = new List<MyListViewItem>();
        List<MyListViewItem> _xlsItemList_2 = new List<MyListViewItem>();
        List<MyListViewItem> _dbItemList_1 = new List<MyListViewItem>();
        List<MyListViewItem> _dbItemList_2 = new List<MyListViewItem>();

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
                    _xlsFilePath = selectFileDialog.FileName;
                    int index = _xlsFilePath.LastIndexOf('\\');
                    _xlsFilePath = _xlsFilePath.Substring(0, index + 1);
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
            List<string> columnList = TextFileHandler.ReadTextFile(@"..\..\text\" + fileName);
            List<MyListViewItem> myItemList = CreateListViewItems(columnList);
            foreach (var item in myItemList)
            {
                _dbItemList_1.Add(item);
                listBox_db_start.Items.Add(item.Text);
            }
        }

        List<MyListViewItem> CreateListViewItems(List<string> list)
        {
            List<MyListViewItem> resList = new List<MyListViewItem>();
            int counter = 0;
            foreach (var item in list)
            {
                MyListViewItem i = new MyListViewItem {Id = counter++, Text = item};
                resList.Add(i);
            }
            return resList;
        }

        void InsertXlsToListBox()
        {
            if (Mediator.IsReady)
            {
                int counter = 0;
                List<string> strList = new List<string>();
                for (int i = 0; i< Mediator.DataList.Count; i++)
                {
                    List<string> tempList = Mediator.DataList[i];
                    string str = "";
                    foreach (var item in tempList)
                    {
                        str +=  item + " | ";
                    }
                    str += counter.ToString();
                    counter++;
                    strList.Add(str);
                }
                _xlsItemList_1 = CreateListViewItems(strList);
                Mediator.StartList = _xlsItemList_1;
                foreach (var item in _xlsItemList_1)
                {
                    listBox_xls_start.Items.Add(item.Text);
                }
            }            
        }

        void MoveItem(List<MyListViewItem> from, List<MyListViewItem> to, MyListViewItem mi)
        {
            from.Remove(mi);
            to.Add(mi);
        }

        void ReDrow(ListBox lb, List<MyListViewItem> list)
        {
            lb.Items.Clear();
            foreach (var item in list)
            {
                lb.Items.Add(item.Text);
            }
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

        void SetCreateButtonStatus()
        {
            int xlsCount = listBox_xls_finish.Items.Count;
            int dbCount = listBox_db_finish.Items.Count;
            if (xlsCount == dbCount && xlsCount != 0)
            {
                button_create_ctrl.Enabled = true;
            }
            else
            {
                button_create_ctrl.Enabled = false;
            }
        }

        private void listBox_xls_start_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBox_xls_start.SelectedItem == null)
                {
                    return;
                }
                MyListViewItem myItem = _xlsItemList_1.Where(i => i.Text == listBox_xls_start.SelectedItem.ToString()).First();
                MoveItem(_xlsItemList_1, _xlsItemList_2, myItem);
                ReDrow(listBox_xls_start, _xlsItemList_1);
                ReDrow(listBox_xls_finish, _xlsItemList_2);
                SetCreateButtonStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception from listBox_xls_start_SelectedIndexChanged \n" + ex.Message);
            }            
        }

        private void listBox_xls_finish_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBox_xls_finish.SelectedItem == null)
                {
                    return;
                }
                MyListViewItem myItem = _xlsItemList_2.Where(i => i.Text == listBox_xls_finish.SelectedItem.ToString()).First();
                MoveItem(_xlsItemList_2, _xlsItemList_1, myItem);
                _xlsItemList_1.Sort((x, y) => x.Id.CompareTo(y.Id));
                ReDrow(listBox_xls_start, _xlsItemList_1);
                ReDrow(listBox_xls_finish, _xlsItemList_2);
                SetCreateButtonStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception from listBox_xls_finish_SelectedIndexChanged \n" + ex.Message);
            }            
        }

        private void listBox_db_start_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBox_db_start.SelectedItem == null)
                {
                    return;
                }
                else
                {
                    string str = listBox_db_start.SelectedItem.ToString();
                    if (str.Contains("--"))
                    {
                        return;
                    }
                }
                MyListViewItem myItem = _dbItemList_1.Where(i => i.Text == listBox_db_start.SelectedItem.ToString()).First();
                MoveItem(_dbItemList_1, _dbItemList_2, myItem);
                ReDrow(listBox_db_start, _dbItemList_1);
                ReDrow(listBox_db_finish, _dbItemList_2);
                SetCreateButtonStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception from listBox_db_start_SelectedIndexChanged \n" + ex.Message);
            }
        }


        private void listBox_db_finish_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (listBox_db_finish.SelectedItem == null)
                {
                    return;
                }
                MyListViewItem myItem = _dbItemList_2.Where(i => i.Text == listBox_db_finish.SelectedItem.ToString()).First();
                MoveItem(_dbItemList_2, _dbItemList_1, myItem);
                _dbItemList_1.Sort((x, y) => x.Id.CompareTo(y.Id));
                ReDrow(listBox_db_start, _dbItemList_1);
                ReDrow(listBox_db_finish, _dbItemList_2);
                SetCreateButtonStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception from listBox_xls_finish_SelectedIndexChanged \n" + ex.Message);
            }
        }

        private void button_create_ctrl_Click(object sender, EventArgs e)
        {
            try
            {
                Mediator.PairList = CreatePairList();
                if (TextFileHandler.CreateTextFile(_xlsFilePath))
                {
                    MessageBox.Show(_xlsFilePath + Settings.CtrlFileName, "Файл успешно создан!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception from button_create_ctrl_Click. " + ex.Message);
            }
        }

        List<XlsDbPair> CreatePairList()
        {
            List<XlsDbPair> resList = new List<XlsDbPair>();
            int itemCount = listBox_xls_finish.Items.Count;
            for (int i = 0; i < itemCount; i++)
            {
                XlsDbPair pair = new XlsDbPair
                {
                    XlsRowId = _xlsItemList_2[i].Id,
                    //DbRowID = _dbItemList_2[i].Id,
                    //XlsRowText = _xlsItemList_2[i].Text,
                    DbRowText = _dbItemList_2[i].Text
                };
                resList.Add(pair);
            }
            return resList;
        }
    }
}
