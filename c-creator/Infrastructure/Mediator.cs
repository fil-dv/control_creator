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
        public static List<List<string>> DataList { get { return _list; } set { _list = value; }} 
    }
}
