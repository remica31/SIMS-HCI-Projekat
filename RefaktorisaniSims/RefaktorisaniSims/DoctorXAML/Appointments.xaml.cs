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
    /// Interaction logic for Appointments.xaml
    /// </summary>
    public partial class Appointments : Window
    {
        App application;
        List<Appointment> appointments = new List<Appointment>();
        Doctor doc = new Doctor();
        public Appointments()
        {
            InitializeComponent();
            application = Application.Current as App;
            doc = application.doctorController.GetById(application.id);
            appointments = application.appointmentController.GetByDoctorId(application.id);
          /*  List<Appointment> appointmentsShow = new List<Appointment>();
            var datum = date.SelectedDate;
            
            foreach(var app in appointments)
            {
                if (app.StartTime.Date == datum)
                {
                    appointmentsShow.Add(app);
                }
            }
            bindingApps.ItemsSource = appointments;*/
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            Main m = new Main();
            m.Show();
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Approve a = new Approve();
            a.Show();
            this.Close();
        }

        private void translate_Click(object sender, RoutedEventArgs e)
        {
            Pregledi p = new Pregledi();
            p.Show();
            this.Close();
        }

        private void prescribe_Click(object sender, RoutedEventArgs e)
        {
            if (appId.Content.ToString() == "/")
            {
                MessageBox.Show("You need to select appointment");
            }
            else
            {
                PrescribeMedication p = new PrescribeMedication();
                p.Show();
                this.Close();
            }
            
        }

        private void Hospital_treatment(object sender, RoutedEventArgs e)
        {

            if (appId.Content.ToString() == "/")
            {
                MessageBox.Show("You need to select appointment");
            }
            else
            {
                HospitalTreatment h = new HospitalTreatment();
                h.Show();
                this.Close();
            }


           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ExtendTreatment ee = new ExtendTreatment();
            ee.Show();
            this.Close();
        }
    }
}
