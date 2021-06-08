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

namespace RefaktorisaniSims
{
    /// <summary>
    /// Interaction logic for PatientFunctional.xaml
    /// </summary>
    public partial class PatientFunctional : Window
    {
        App application;
        public PatientFunctional()
        {
            InitializeComponent();
            application = Application.Current as App;
            var notificationsMedicines = application.medicineNotificationController.GetAll();
            var notificationsAppointment = application.appointmentNotificationController.GetAll();
            foreach(var not in notificationsMedicines)
            {
                if(not.StartDate<DateTime.Now && not.FinishDate > DateTime.Now)
                {
                    string s = "Obavestenje! Moras popiti lek neki, evo upute: " + not.Description;
                    MessageBox.Show(s);

                }
            }
            var date = DateTime.Now;
            date.AddDays(1);
            foreach(var a in notificationsAppointment)
            {
                if (date > a.Date)
                {
                    MessageBox.Show(a.Description);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PatientAppointmentsCRUD p = new PatientAppointmentsCRUD();
            p.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PatientAppointmentPriority p = new PatientAppointmentPriority();
            p.Show();
        }

        private void Survey_Click(object sender, RoutedEventArgs e)
        {
            PatientSurvey p = new PatientSurvey();
            p.Show();
        }

        private void Referral(object sender, RoutedEventArgs e)
        {
            PatientReferral p = new PatientReferral();
            p.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MedicalRecord med = new MedicalRecord();
            med.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            PatientNote pn = new PatientNote();
            pn.Show();
        }
    }
}
