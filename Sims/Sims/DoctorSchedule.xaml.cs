using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Sims
{
    /// <summary>
    /// Interaction logic for DoctorSchedule.xaml
    /// </summary>
    public partial class DoctorSchedule : Window
    {
        public DoctorSchedule()
        {
            InitializeComponent();
        }

        private void View_Click(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
            FileStoragePatient storagePatients = new FileStoragePatient();
            FileStorageAppointmentDoctor storage = new FileStorageAppointmentDoctor();
            storage.patients = storagePatients.GetPatients();
            storage.ReadAppointments();
            storage.ReadOperations();
            List<Operations> operations = storage.GetOperationsByDOC(textBox1.Text);
            List<Appointment> appointments = storage.GetAppointmentsByDOC(textBox1.Text);
            lvDataBinding4.ItemsSource = operations;
            lvDataBinding5.ItemsSource = appointments;
            //this.Close();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void View(object sender, RoutedEventArgs e)
        {
            FileStoragePatient storage = new FileStoragePatient();
            List<Patient> patients = storage.GetPatientByID(textBox2.Text);
            lvDataBinding3.ItemsSource = patients;

        }
    }
}
