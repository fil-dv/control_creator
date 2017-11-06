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
            StringBuilder builder = new StringBuilder();
            builder.Append("LOAD DATA\nINFILE 'IMP.CSV'\nREPLACE\nINTO TABLE IMPORT_CLNT_EXAMPLE\nFIELDS TERMINATED BY ';'\nTRAILING NULLCOLS(");

            return builder.ToString();
        }
    }
}
