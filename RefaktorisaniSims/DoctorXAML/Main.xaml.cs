using Model;
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

namespace RefaktorisaniSims.DoctorXAML
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
   
    public partial class Main : Window
    {
        App application;
        Doctor doc;
        public Main()
        {
            InitializeComponent();
            application = Application.Current as App;
            doc = application.doctorController.GetById(application.id);
            firstname.Content = doc.User.Name;
            surname.Content = doc.User.Surname;
            id.Content = doc.User.Id;
            address.Content = doc.User.Address;
            specialization.Content = doc.SpecializationType;
            phone.Content = doc.User.Phone;
            //room.Content = doc.Room.Number;
            email.Content = doc.User.EMail;
            
        }

        private void Appointments_Click(object sender, RoutedEventArgs e)
        {
            Appointments a = new Appointments();
            a.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Pocetna p = new Pocetna();
            p.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Approve a = new Approve();
            a.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();
        }
    }
}
