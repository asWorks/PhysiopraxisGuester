using MySQL_Test_EF6;
using System.Linq;
using System.Windows;

namespace MySQL_Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            using (var db = new GuesterModel())
            {
                var aerzte = db.arzts;
                arzt arzt = aerzte.Where(n => n.NACHNAME == "Bauer").First();
                textBlock.Text = arzt.PLZ;
                textBlock1.Text = arzt.VORNAME;
                textBox.Text = arzt.VORNAME;
                arzt.VORNAME = "Woolfgaang";
                var saveChanges = db.SaveChanges();

                // MessageBox.Show(arzt.);
                // MessageBox.Show(aerzte.Count().ToString());
            }

        }
    }
}
