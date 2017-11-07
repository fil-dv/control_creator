using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace c_creator.Infrastructure
{
    public static class CtrlStringBuilder
    {
        public static string BuildString()
        {
            int counter = Settings.CommentStart;
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("LOAD DATA");
            builder.AppendLine("INFILE 'imp.csv'");
            builder.AppendLine("REPLACE");
            builder.AppendLine("INTO TABLE IMPORT_CLNT_EXAMPLE");
            builder.AppendLine("FIELDS TERMINATED BY ';'");
            builder.AppendLine("TRAILING NULLCOLS");
            builder.AppendLine("(");

            List<XlsDbPair> pairList = Mediator.PairList;
            for (int i = 0; i < Mediator.DataList.Count; i++)
            {
                List<XlsDbPair> pairs = pairList.Where((x, y) => x.XlsRowId == i).ToList();
                if (pairs.Count == 0)
                {
                    builder.Append("COMMENT" + counter.ToString());
                    counter++;
                }
                else
                {
                    builder.Append(pairs[0].DbRowText);                    
                }
                if (i != Mediator.DataList.Count - 1)
                {
                    builder.AppendLine(",");                    
                }
                else
                {
                    if (Settings.IsRegister)
                    {
                        builder.AppendLine(",");
                        builder.AppendLine("END_OF_REG");
                    }
                    else
                    {
                        builder.AppendLine("");
                    }                    
                    builder.AppendLine(")");
                }
            }       
            return builder.ToString();
        }
    }
}
