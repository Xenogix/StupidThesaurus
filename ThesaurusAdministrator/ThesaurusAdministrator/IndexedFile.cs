using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesaurusAdministrator
{
    public class IndexedFile
    {
        public FileManager.FileType filType { get; set; }
        public string filDirectory { get; set; }
        public string filName { get; set; }


        public IndexedFile(FileManager.FileType filType, string filDirectory, string filName)
        {
            this.filType = filType;
            this.filDirectory = filDirectory;
            this.filName = filName;
            Console.WriteLine(filType + ", " + filDirectory + ", " + filName);
        }
    }
}
