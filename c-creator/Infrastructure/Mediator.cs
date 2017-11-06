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

        static List<XlsDbPair> _pairList { get; set; }
        public static List<XlsDbPair> PairList { get { return _pairList; } set { _pairList = value; } }
        static List<MyListViewItem> _startList { get; set; }
        public static List<MyListViewItem> StartList { get { return _startList; } set { _startList = value; } }
        
    }
}
