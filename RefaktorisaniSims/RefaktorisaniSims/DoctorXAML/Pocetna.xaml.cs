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
    /// Interaction logic for Pocetna.xaml
    /// </summary>
    public partial class Pocetna : Window
    {
        App application;
        Doctor doc;
        public Pocetna()
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Close();
        }

        private void Appointments_Click(object sender, RoutedEventArgs e)
        {
            Pregledi p = new Pregledi();
            p.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OdobriLek o = new OdobriLek();
            o.Show();
            this.Close();
        }

        private void Odjava_Click(object sender, RoutedEventArgs e)
        {
            Logovanje l = new Logovanje();
            this.Close();
            l.Show();
        }
    }
}
