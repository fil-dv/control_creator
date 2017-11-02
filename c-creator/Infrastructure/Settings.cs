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
    }
}
