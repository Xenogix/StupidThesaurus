using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThesaurusFinder.Controllers;
using ThesaurusFinder.Models;

namespace ThesaurusFinder
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DefaultView myView = new DefaultView();
            DefaultModel myModel = new DefaultModel();
            DefaultController myController = new DefaultController(myView, myModel);

            Application.Run(myView);
        }
    }
}
