using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_creator.Infrastructure
{
    static class Settings
    {
        static int _rowCount = 5;
        public static int RowCount { get { return _rowCount; } set { _rowCount = value; } }

        public static string _ctrlFileName = "1_import.CTL";
        public static string CtrlFileName { get { return _ctrlFileName; } set { _ctrlFileName = value; } }
    }
}
