using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_creator.Infrastructure
{
    public static class Mediator
    {
        static List<List<string>> _list = new List<List<string>>();
        public static List<List<string>> DataList { get { return _list; } set { _list = value; } }
        static bool _isReady = false;
        public static bool IsReady { get { return _isReady; } set { _isReady = value; } }
        //static bool _isInvert = false;
        // static bool IsInvert { get { return _isInvert; } set { _isInvert = value; } }

        //public static void Invert()
        //{
        //    if (_isInvert)
        //    {
        //        return;
        //    }

        //    List<List<string>> invertList = new List<List<string>>();
        //    for (int i = 0; i < _list.Count; i++)
        //    {
        //        List<string> tmpList = new List<string>();
        //        invertList.Add(tmpList);
        //    }

        //    for (int i = 0; i < Settings.RowCount; i++)
        //    {
        //        //List<string> rowList = Mediator.DataList[i];

        //        for (int j = 0; j < invertList.Count; j++)
        //        {
        //            //invertList[i]
        //        }

        //        //string str = (i + 1).ToString() + ") ";

        //        //foreach (var item in tempList)
        //        //{
        //        //    str +=  item + " * ";
        //        //}
        //        //listBox_xls_start.Items.Add(str);
        //    }
        //    _isInvert = true;            
        //}        
    }
}
