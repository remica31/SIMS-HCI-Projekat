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

namespace RefaktorisaniSims
{
    /// <summary>
    /// Interaction logic for SecretaryCRUDAppAndOp.xaml
    /// </summary>
    public partial class SecretaryCRUDAppAndOp : Window
    {
        App application;
        List<Appointment> appointments = new List<Appointment>();
        List<Patient> patients = new List<Patient>();
        List<Doctor> doctors = new List<Doctor>();
        List<Operation> operations = new List<Operation>();
        List<AppointmentNotification> notifications = new List<AppointmentNotification>();
        public SecretaryCRUDAppAndOp()
        {
            InitializeComponent();
            application = Application.Current as App;
            appointments = application.appointmentController.GetAll();
            doctors = application.doctorController.GetAll();
            operations = application.operationController.GetAll();
            notifications = application.appointmentNotificationController.GetAll();
            //patients = application.patientController.GetAll();
        }

        private void Add_appointment(object sender, RoutedEventArgs e)
        {
            var doc = application.doctorController.GetById(textBox5.Text);
            var pat = application.patientController.GetById(textBox6.Text);
            Appointment a = new Appointment(textBox1.Text, (DateTime)datum.SelectedDate, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), doc, pat);
            application.appointmentController.Save(a);
        }

        private void View_appointments(object sender, RoutedEventArgs e)
        {
            appointments = application.appointmentController.GetAll();
            lvDataBinding3.ItemsSource = appointments;
        }

        private void Update_appointment(object sender, RoutedEventArgs e)
        {
            appointments = application.appointmentController.GetAll();
            foreach (var app in appointments)
            {
                if (app.Id == textBox1.Text)
                {
                    string descriptionNotification = "Pregled sa id-ijem " + app.Id + " je pomeren, pogledajte raspored da vidite detalje.";
                    var newNotification = new AppointmentNotification(notifications.Count+1, DateTime.Now, descriptionNotification, app.patient.User.Id, app.doctor.User.Id);
                    application.appointmentNotificationController.Save(newNotification);

                    var temp1 = app.doctor;
                    var temp2 = app.patient;
                    application.appointmentController.Delete(app.Id);
                    var updatedApp = new Appointment(textBox1.Text, (DateTime)datum.SelectedDate, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), temp1, temp2);
                    application.appointmentController.Save(updatedApp);
                    break;
                }
            }
        }

        private void Delete_appointment(object sender, RoutedEventArgs e)
        {
            appointments = application.appointmentController.GetAll();
            foreach (var app in appointments)
            {
                if (app.Id == textBox1.Text)
                {
                    application.appointmentController.Delete(app.Id);
                    break;
                }
            }
        }

        private void Add_operation(object sender, RoutedEventArgs e)
        {
            var doc = application.doctorController.GetById(textBox5.Text);
            var pat = application.patientController.GetById(textBox6.Text);
            Operation o = new Operation(textBox1.Text, (DateTime)datum.SelectedDate, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), doc, pat);
            application.operationController.Save(o);
        }

        private void View_operations(object sender, RoutedEventArgs e)
        {
            operations = application.operationController.GetAll();
            lvDataBinding2.ItemsSource = operations;
        }

        private void Update_operation(object sender, RoutedEventArgs e)
        {
            operations = application.operationController.GetAll();
            foreach (var app in operations)
            {
                if (app.Id == textBox1.Text)
                {
                    var temp1 = app.doctor;
                    var temp2 = app.patient;
                    application.operationController.Delete(app.Id);
                    var updatedApp = new Operation(textBox1.Text, (DateTime)datum.SelectedDate, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), temp1, temp2);
                    application.operationController.Save(updatedApp);
                    break;
                }
            }
        }

        private void Delete_operation(object sender, RoutedEventArgs e)
        {
            operations = application.operationController.GetAll();
            foreach (var app in operations)
            {
                if (app.Id == textBox1.Text)
                {
                    application.operationController.Delete(app.Id);
                    break;
                }
            }
        }

       
    }
}
