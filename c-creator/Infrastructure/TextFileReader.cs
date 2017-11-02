using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_creator.Infrastructure
{
    public static class TextFileReader
    {
        public static List<string> ReadTextFile(string fileName)
        {
            List<string> resList = new List<string>();

            using (var streamReader = File.OpenText(fileName))
            {
                var lines = streamReader.ReadToEnd().Split(',');
                foreach (var line in lines)
                {
                    resList.Add(line.Trim());
                }
            }
            return resList;
        }
    }
}
