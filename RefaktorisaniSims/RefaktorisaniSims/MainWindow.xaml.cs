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
            DoctorMainWindow d = new DoctorMainWindow();
            d.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DoctorWarden dw = new DoctorWarden();
            dw.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SecretaryFunctional s = new SecretaryFunctional();
            s.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (application.counterCancel > 4)
            {
                MessageBox.Show("YOU ARE IMPOSTOR");

            }
            else
            {
                PatientFunctional p = new PatientFunctional();
                p.Show();
            }
            
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "d")
            {
                application.id = "d";
                DoctorMainWindow d = new DoctorMainWindow();
                d.Show();
            }
            else if(textBox1.Text == "p")
            {
                application.id = "p";
                PatientFunctional p = new PatientFunctional();
                p.Show();
            }
            else if (textBox1.Text == "s")
            {
                application.id = "s";
                SecretaryFunctional s = new SecretaryFunctional();
                s.Show();
            }
            else if (textBox1.Text == "w")
            {
                application.id = "w";
                Warden w = new Warden();
                w.Show();
            }
            else
            {
                application.id = "dw";
                DoctorWarden dw = new DoctorWarden();
                dw.Show();
            }
        }

        
    }
}
