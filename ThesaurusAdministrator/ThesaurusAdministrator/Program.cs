using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThesaurusAdministrator
{
    class Program
    {
        static void Main(string[] args)
        {
            SetProcessDPIAware();

            Application.Run(new AdminConsole());
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
