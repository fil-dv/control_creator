using System.Collections.Generic;

namespace c_creator.Infrastructure
{
    public static class Mediator
    {
        public static string PathToFile { get; set; }

        static List<List<string>> _list = new List<List<string>>();
        public static List<List<string>> DataList { get { return _list; } set { _list = value; } }
        static bool _isReady = false;
        public static bool IsReady { get { return _isReady; } set { _isReady = value; } }

        static List<XlsDbPair> _pairList { get; set; }
        public static List<XlsDbPair> PairList { get { return _pairList; } set { _pairList = value; } }
    }
}
