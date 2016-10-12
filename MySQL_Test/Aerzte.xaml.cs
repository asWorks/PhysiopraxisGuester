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
using System.Windows.Shapes;

namespace MySQL_Test
{
    /// <summary>
    /// Interaction logic for Aerzte.xaml
    /// </summary>
    public partial class Aerzte : Window
    {
        public Aerzte()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource arztViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("arztViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // arztViewSource.Source = [generic data source]
        }
    }
}
