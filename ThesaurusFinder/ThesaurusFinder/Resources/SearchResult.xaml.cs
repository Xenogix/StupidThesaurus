using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ThesaurusFinder.Resources
{
    /// <summary>
    /// Logique d'interaction pour SearchResult.xaml
    /// </summary>
    public partial class SearchResult : UserControl
    {
        public string Title { get; set; }
        public int MaxLength { get; set; }

        public SearchResult()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void txtLimitedInput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
