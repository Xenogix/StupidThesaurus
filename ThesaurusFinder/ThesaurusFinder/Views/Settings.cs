using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThesaurusFinder.Views
{
    public partial class Settings : Form
    {
        private string baseDirectory;
        public string BaseDirectory { get => directory; set => directory = value; }
        private string directory;
        public string Directory { get => directory; set => directory = value; }


        public Settings()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
