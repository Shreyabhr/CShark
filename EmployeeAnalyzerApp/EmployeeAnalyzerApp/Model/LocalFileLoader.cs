using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EmployeeAnalyzerApp.Model
{
    class LocalFileLoader : IFileLoader
    {
        public string[] LoadFile(string filepath)
        {
            var data = new HashSet<string>(File.ReadAllLines(filepath));
            string[] lines = data.ToArray();
            return lines;
        }

        
    }
}
