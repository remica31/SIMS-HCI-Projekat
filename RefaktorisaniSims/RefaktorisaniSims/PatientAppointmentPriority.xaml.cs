using Model;
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

namespace RefaktorisaniSims
{
    /// <summary>
    /// Interaction logic for PatientAppointmentPriority.xaml
    /// </summary>
    public partial class PatientAppointmentPriority : Window
    {
        App application;
        List<Appointment> appointments = new List<Appointment>();
        //  List<Patient> patients = new List<Patient>();
        List<Patient> patients = new List<Patient>();
        List<Doctor> doctors = new List<Doctor>();
        List<AvailableAppointment> availableAppointments = new List<AvailableAppointment>();


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }




        private double _test3;

        public double Test3
        {
            get
            {
                return _test3;
            }
            set
            {
                if (value != _test3)
                {
                    _test3 = value;
                    OnPropertyChanged("Test3");
                }
            }
        }
        public PatientAppointmentPriority()
        {
            InitializeComponent();
            application = Application.Current as App;
            appointments = application.appointmentController.GetAll();
            doctors = application.doctorController.GetAll();
            patients = application.patientController.GetAll();
            availableAppointments = application.availableAppointmentController.GetAll();
            this.DataContext = this;
        }

        private void View_Click(object sender, RoutedEventArgs e)
        {
              List<AvailableAppointment> availableAppointmentsShow = new List<AvailableAppointment>();
              var doc = application.doctorController.GetById(textBox1.Text);
              foreach(var a in availableAppointments)
              {
                  if (a.StartTime > datum.SelectedDate && a.FinishTime<datum2.SelectedDate && a.doctor.User.Id==textBox1.Text)
                  {
                      availableAppointmentsShow.Add(a);
                  }
              }
              var i = availableAppointmentsShow.Count;
              if (i == 0)
              {
                  if (textBox2.Text == "Date")
                  {
                      foreach(var a in availableAppointments)
                      {
                          if (a.StartTime > datum.SelectedDate && a.FinishTime < datum2.SelectedDate)
                          {
                              availableAppointmentsShow.Add(a);
                          }
                      }
                  }
                  else if (textBox2.Text == "Doctor")
                  {
                      foreach(var a in availableAppointments)
                      {
                          if (a.doctor.User.Id == textBox1.Text)
                          {
                              availableAppointmentsShow.Add(a);
                          }
                      }
                  }
              }
              lvDataBinding3.ItemsSource = availableAppointmentsShow;
            
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var a = application.availableAppointmentController.GetById(textBox3.Text);
            var patient = application.patientController.GetById(textBox4.Text);
            var newApp = new Appointment(Convert.ToString(appointments.Count + 1), a, patient);
            application.appointmentController.Save(newApp);
            application.availableAppointmentController.Delete(textBox3.Text);

        }
    }
}
