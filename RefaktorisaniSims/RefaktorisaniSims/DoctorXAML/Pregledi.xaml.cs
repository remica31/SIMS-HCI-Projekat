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
    /// Interaction logic for Pregledi.xaml
    /// </summary>
    public partial class Pregledi : Window
    {
        App application;
        List<Appointment> appointments = new List<Appointment>();
        Doctor doc = new Doctor();
        public Pregledi()
        {
            InitializeComponent();
            application = Application.Current as App;
            doc = application.doctorController.GetById(application.id);
            appointments = application.appointmentController.GetByDoctorId(application.id);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OdobriLek o = new OdobriLek();
            o.Show();
            this.Close();
        }

        private void show_click(object sender, RoutedEventArgs e)
        {
            var datum = (DateTime)date.SelectedDate;
            List<Appointment> appointmentsShow = new List<Appointment>();
            foreach (var app in appointments)
            {
                if (app.StartTime.Date == datum.Date)
                {
                    appointmentsShow.Add(app);
                }
            }
            bindingApps.ItemsSource = appointmentsShow;
        }

        private void select_click(object sender, RoutedEventArgs e)
        {
            var app = (Appointment)bindingApps.SelectedItem;
            appId.Content = app.Id;
            name.Content = app.patient.User.Name;
            surname.Content = app.patient.User.Surname;
            address.Content = app.patient.User.Address;
            phone.Content = app.patient.User.Phone;
            application.app_id = app.Id;
        }

        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Pocetna p = new Pocetna();
            p.Show();
            this.Close();
        }

        private void translate_Click(object sender, RoutedEventArgs e)
        {
            Appointments a = new Appointments();
            a.Show();
            this.Close();
        }

        private void prepisi_Click(object sender, RoutedEventArgs e)
        {
            if (appId.Content.ToString() == "/")
            {
                MessageBox.Show("Odaberi termin za koji prepisujes lek");
            }
            else
            {
                PrepisiLek p = new PrepisiLek();
                p.Show();
                this.Close();
            }
            
        }
    }
}
