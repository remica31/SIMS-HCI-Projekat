using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace RefaktorisaniSims
{
    /// <summary>
    /// Interaction logic for PatientReferral.xaml
    /// </summary>
    public partial class PatientReferral : Window
    {
        App applicaton;
        List<Appointment> apps = new List<Appointment>();
        List<AvailableAppointment> availables = new List<AvailableAppointment>();




        public PatientReferral()
        {
            InitializeComponent();
            applicaton = Application.Current as App;
            apps = applicaton.appointmentController.GetAll();
            availables = applicaton.availableAppointmentController.GetAll();
           
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            HospitalReferral referral = (HospitalReferral)lvDataBinding_Show.SelectedItem;
            var pat =applicaton.patientController.GetById(textBox1.Text);
            var docId = referral.ToDoctorId;
            var countIdApp = apps.Count + 1;
            string Id = Convert.ToString(countIdApp);
            AvailableAppointment a = applicaton.availableAppointmentController.GetById(textBox2.Text);
            Doctor doc = applicaton.doctorController.GetById(docId);
            Appointment newApp = new Appointment(Id, a, pat);
            applicaton.availableAppointmentController.Delete(textBox2.Text);
            applicaton.appointmentController.Save(newApp);
            applicaton.hospitalReferralController.Delete(referral.Id);
            

        }

        private void View(object sender, RoutedEventArgs e)
        {
            List<HospitalReferral> showReferrals  = new List<HospitalReferral>();
            var referrals = applicaton.hospitalReferralController.GetAll();
            foreach(var referral in referrals)
            {
                if (referral.Patient.User.Id == textBox1.Text)
                {
                    showReferrals.Add(referral);
                }
            }
            lvDataBinding_Show.ItemsSource = showReferrals;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<AvailableAppointment> availableAppointmentsToShow = new List<AvailableAppointment>();
            HospitalReferral referral = (HospitalReferral)lvDataBinding_Show.SelectedItem;
            foreach (var app in availables)
            {
                if(app.doctor.User.Id== referral.ToDoctorId)
                {
                    availableAppointmentsToShow.Add(app);
                }
            }
            lvDataBinding3.ItemsSource = availableAppointmentsToShow;
        }
    }
}
