using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesaurusAdministrator.Readers
{
    interface FileReader
    {
        string GetPath();
        string SetPath(string path);
        List<string> GetWords();
        string LoadText(string path);
        List<string> ExctractWords();
    }
}
