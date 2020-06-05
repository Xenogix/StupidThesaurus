using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThesaurusFinder.Controllers;
using ThesaurusFinder.Views;

namespace ThesaurusFinder
{
    public partial class DefaultView : Form
    {
        public DefaultController myController;
        private Settings mySettings = new Settings();

        public DefaultView()
        {
            InitializeComponent();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                Search();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
        private void Search()
        {
            txtSearch.Clear();
            
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings tempSettings = new Settings();
            tempSettings.BaseDirectory = mySettings.BaseDirectory;
            tempSettings.Directory = mySettings.Directory;
            tempSettings.Show();
            tempSettings.FormClosing += new FormClosingEventHandler(SaveSettings);
        }

        private void SaveSettings(object sender, FormClosingEventArgs e)
        {
            Settings settings = (Settings)sender;
            //settings.BaseDirectory 
        }
    }
}
