using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace c_creator.Infrastructure
{
    public class ExcelReader
    {

        static Application _xlApp;
        static Workbook _xlWorkBook;
        static Worksheet _xlWorkSheet;
        Ctrl_creator _mainForm;
        Range _xlRange;

        public ExcelReader(Ctrl_creator mainForm, string path)
        {
            _mainForm = mainForm;
            _xlApp = new Microsoft.Office.Interop.Excel.Application();
            _xlWorkBook = _xlApp.Workbooks.Open(path, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            _xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)_xlWorkBook.Sheets[1];
            _xlRange = _xlWorkSheet.UsedRange;
        }

        public void Read()
        {
            // просмотрим с 1-ой по 5-ую строки
            int lastColumnIndex = 5;
            
            for (int i = 1; i <= lastColumnIndex; i++)
            {
                List<string> tmpList = new List<string>();
                tmpList.Clear();
                for (int j = 1; j <= _xlRange.Columns.Count; j++)
                {
                    tmpList.Add(Convert.ToString(((Range)_xlWorkSheet.Cells[i, j]).Value));
                }
                Mediator.DataList.Add(tmpList);
            }
        }
    }
}
