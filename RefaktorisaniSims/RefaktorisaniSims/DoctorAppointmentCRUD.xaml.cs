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
    /// Interaction logic for DoctorFunctional.xaml
    /// </summary>
    public partial class DoctorAppointmentCRUD : Window
    {
        App application;
        List<Appointment> appointments = new List<Appointment>();
        //  List<Patient> patients = new List<Patient>();
        List<Patient> patients = new List<Patient>();
        List<Doctor> doctors = new List<Doctor>();
        public DoctorAppointmentCRUD()
        {
            InitializeComponent();
            application = Application.Current as App;
            appointments = application.appointmentController.GetAll();
            doctors = application.doctorController.GetAll();
            //patients = application.patientController.GetAll();
            patients = application.patientController.GetAll();
        }

        private void Add_appointment(object sender, RoutedEventArgs e)
        {
            /*  var temp = (DateTime)datum.SelectedDate;
              int day=temp.Day;
              int month=temp.Month;
              int year=temp.Year;
              int hours=temp.Hour;
              int minutes=temp.Minute;
              var newStartTime = new DateTime(day,month,year,hours,minutes,0); */
            var doc = application.doctorController.GetById(textBox5.Text);
            var pat = application.patientController.GetById(textBox6.Text);
            Appointment a = new Appointment(textBox1.Text, (DateTime)datum.SelectedDate, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text),doc,pat);
            application.appointmentController.Save(a);

        }

        private void View_appointments(object sender, RoutedEventArgs e)
        {
            appointments = application.appointmentController.GetAll();
            lvDataBinding.ItemsSource = appointments;
        }

        private void Update_appointment(object sender, RoutedEventArgs e)
        {
            appointments = application.appointmentController.GetAll();
            foreach(var app in appointments)
            {
                if (app.Id == textBox1.Text)
                {
                    var temp1 = app.doctor;
                    var temp2 = app.patient;
                    application.appointmentController.Delete(app.Id);
                    var updatedApp = new Appointment(textBox1.Text, (DateTime)datum.SelectedDate, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text),temp1,temp2);                
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

        
    }
}
