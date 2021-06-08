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
    /// Interaction logic for PatientAppointmentsCRUD.xaml
    /// </summary>
    public partial class PatientAppointmentsCRUD : Window
    {
        App application;
        List<Appointment> appointments = new List<Appointment>();
        //  List<Patient> patients = new List<Patient>();
        List<Patient> patients = new List<Patient>();
        List<Doctor> doctors = new List<Doctor>();


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
        public PatientAppointmentsCRUD()
        {
            InitializeComponent();
            application = Application.Current as App;
            appointments = application.appointmentController.GetAll();
            doctors = application.doctorController.GetAll();
            patients = application.patientController.GetAll();
            this.DataContext = this;
        }

        private void Add_appointment(object sender, RoutedEventArgs e)
        {

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
                    var helper = app.StartTime;
                    helper.AddDays(2);
                    if (helper < datum.SelectedDate)
                    {
                        MessageBox.Show("You can't change appointment more than two days");
                        break;
                    }
                    else
                    {
                        var temp1 = app.doctor;
                        var temp2 = app.patient;
                        application.appointmentController.Delete(app.Id);
                        var updatedApp = new Appointment(textBox1.Text, (DateTime)datum.SelectedDate, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), temp1, temp2);
                        application.appointmentController.Save(updatedApp);
                        break;
                    }
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
                    var today = DateTime.Now;
                    today.AddDays(1);
                    if (today > app.StartTime)
                    {
                        MessageBox.Show("Can't cancel appointment 24h before");
                        break;
                    }
                    else
                    {
                        application.appointmentController.Delete(app.Id);
                        application.counterCancel++;
                        break;
                    }
                }
            }
        }
    }
}
