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
using Model;
namespace RefaktorisaniSims
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        App application;
        public MainWindow()
        {
            InitializeComponent();
            application = Application.Current as App;

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            DoctorXAML.Login d = new DoctorXAML.Login();
            d.Show();
           /* DoctorMainWindow d = new DoctorMainWindow();
            d.Show(); */
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SecretaryFunctional s = new SecretaryFunctional();
            s.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PatientFunctional p = new PatientFunctional();
            p.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DoctorWarden d = new DoctorWarden();
            d.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Warden w = new Warden();
            w.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            DoctorMainWindow d = new DoctorMainWindow();
            d.Show();
        }
    }
}
