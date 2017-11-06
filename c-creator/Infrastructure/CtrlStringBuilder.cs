using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_creator.Infrastructure
{
    public static class CtrlStringBuilder
    {
        public static string BuildString()
        {
            int counter = Settings.CommentStart;
            StringBuilder builder = new StringBuilder();
            builder.Append("LOAD DATA\nINFILE 'IMP.CSV'\nREPLACE\nINTO TABLE IMPORT_CLNT_EXAMPLE\nFIELDS TERMINATED BY ';'\nTRAILING NULLCOLS(\n");
            List<MyListViewItem> startList = Mediator.StartList;
            List<XlsDbPair> pairList = Mediator.PairList;
            for (int i = 0; i < startList.Count; i++)
            {
                XlsDbPair pair = pairList.Where((x, y) => x.XlsRowId == i).First();
                if (pair == null)
                {
                    builder.AppendLine("COMMENT" + counter.ToString() + ",");
                }
                else
                {
                    builder.AppendLine(pair.DbRowText + ",");
                }
            }

            return builder.ToString();
        }
    }
}
