using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesaurusAdministrator.FileScanner
{
    abstract class FileScanner
    {
        public abstract string[] KeyWords();
        public abstract override string ToString();
    }
}
