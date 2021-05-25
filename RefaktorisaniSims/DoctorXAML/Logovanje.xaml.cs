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
using Model;

namespace RefaktorisaniSims.DoctorXAML
{
    /// <summary>
    /// Interaction logic for Logovanje.xaml
    /// </summary>
    public partial class Logovanje : Window
    {
        App application;
        List<Doctor> doctors = new List<Doctor>();
        public Logovanje()
        {
            InitializeComponent();
            application = Application.Current as App;
            doctors = application.doctorController.GetAll();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            foreach (var doc in doctors)
            {
                if (doc.User.Username == username.Text && doc.User.Password == password.Text)
                {
                    application.id = doc.User.Id;
                    Pocetna p = new Pocetna();
                    p.Show();
                    this.Close();
                    return;
                }
            }
            MessageBox.Show("Pogresno korisnicko ime ili lozinka!");
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();
        }
    }
}
