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

namespace RefaktorisaniSims
{
    /// <summary>
    /// Interaction logic for SecretaryUrgent.xaml
    /// </summary>
    public partial class SecretaryUrgent : Window
    {
        App application;
        List<AvailableAppointment> apps = new List<AvailableAppointment>();
        List<Appointment> appointments = new List<Appointment>();
        bool UseableTermin = false;
        public SecretaryUrgent()
        {
            InitializeComponent();
            application = Application.Current as App;
            apps = application.availableAppointmentController.GetAll();
            appointments = application.appointmentController.GetAll();
        }

        private void Guest(object sender, RoutedEventArgs e)
        {
            CreateGuest c = new CreateGuest();
            c.Show();
        }

        private void View_AppointmentsUrgent(object sender, RoutedEventArgs e)
        {
            List<AvailableAppointment> availableAppointments = new List<AvailableAppointment>();


            availableAppointments = application.availableAppointmentController.existForUrgent(specialization.Text);
            if (availableAppointments.Count != 0)
            {
                UseableTermin = true;
                labelica.Content = "POSTOJE TERMINI U SLEDECIH 30 MINUTA";
                lvDataBinding3.ItemsSource = availableAppointments;
            }
            else
            {
                var appsToCancel = application.appointmentController.AppointmentsToCancel(specialization.Text);
                lvDataBinding3.ItemsSource = appsToCancel;
                labelica.Content = "NE POSTOJE TERMINI U SLEDECIH 30 MINUTA, EVO LISTA TERMINA KOD ZAUZETIH DOKTORA";
            }
            labelica.Visibility = Visibility.Visible;
        }

        private void View_Patients(object sender, RoutedEventArgs e)
        {
            var patients = application.patientController.GetAll();
            patientsSHOW.ItemsSource = patients;
        }

















        private void Add(object sender, RoutedEventArgs e)
        {
            if (UseableTermin == true)
            {
                var id = appointments.Count+1;
                string newId = Convert.ToString(id);
                var patient = application.patientController.GetById(patientID.Text);
                var temp = (AvailableAppointment)lvDataBinding3.SelectedItem;
                AvailableAppointment appointment = new AvailableAppointment();
                appointment = temp;
                var newApp = new Appointment(newId, appointment, patient);
                application.appointmentController.Save(newApp);
                application.availableAppointmentController.Delete(appointment.Id);
            }
            else
            {
                var id = appointments.Count;
                string newId = Convert.ToString(id);
                var patient = application.patientController.GetById(patientID.Text);
                Appointment appointment = (Appointment)lvDataBinding3.SelectedItem;
                appointment.patient = patient;
                var newApp = appointment;
                application.appointmentController.Delete(appointment.Id);
                application.appointmentController.Save(newApp);

            }

        }

        private void AddUseGuest(object sender, RoutedEventArgs e)
        {
            if (UseableTermin == true)
            {
                var id = appointments.Count;
                string newId = Convert.ToString(id);
                Guest guest = application.guestController.GetById(patientID.Text);
                Patient patient = new Patient(guest);
                AvailableAppointment appointment = (AvailableAppointment)lvDataBinding3.SelectedItem;
                var newApp = new Appointment(newId, appointment, patient);
                application.appointmentController.Save(newApp);
                application.availableAppointmentController.Delete(appointment.Id);
            }
            else
            {
                var id = appointments.Count;
                string newId = Convert.ToString(id);
                Guest guest = application.guestController.GetById(patientID.Text);
                Patient patient = new Patient(guest);
                var appointment = (Appointment)lvDataBinding3.SelectedItem;
                appointment.patient = patient;
                var newApp = appointment;
                application.appointmentController.Delete(appointment.Id);
                application.appointmentController.Save(newApp);
                
            }
        }
    }
}
