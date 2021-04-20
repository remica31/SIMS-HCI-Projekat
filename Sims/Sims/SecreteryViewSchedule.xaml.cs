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
    /// Interaction logic for SecreteryViewSchedule.xaml
    /// </summary>
    public partial class SecreteryViewSchedule : Window
    {
        public SecreteryViewSchedule()
        {
            InitializeComponent();
            FileStoragePatient storagePatients = new FileStoragePatient();
            FileStorageAppointmentDoctor storage = new FileStorageAppointmentDoctor();
            storage.patients = storagePatients.GetPatients();
            storage.ReadAppointments();
            storage.ReadOperations();
            List<Operations> operations = storage.GetOperations();
            List<Appointment> appointments = storage.GetAppointments();
            lvDataBinding77.ItemsSource = operations;
            lvDataBinding78.ItemsSource = appointments;
        }

      

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            UpdateApp u = new UpdateApp();
           
            u.Show();
        }

        private void Cancel_App(object sender, RoutedEventArgs e)
        {
            CancelApp c = new CancelApp();
           
            c.Show();
        }

        private void UpdateOP_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            UpdateOperationsBySecretary u = new UpdateOperationsBySecretary();
            u.Show();
        }

        private void CancelOP_Click(object sender, RoutedEventArgs e)
        {
            FileStorageAppointmentDoctor storage = new FileStorageAppointmentDoctor();
            storage.ReadOperations();
            storage.DeleteOperation(textBox1.Text);
            storage.WriteOperations();
            FileStoragePatient storagePatients = new FileStoragePatient();
            FileStorageAppointmentDoctor storage2= new FileStorageAppointmentDoctor();
            storage.patients = storagePatients.GetPatients();
            storage2.ReadAppointments();
            storage2.ReadOperations();
            List<Operations> operations = storage2.GetOperations();
            List<Appointment> appointments = storage2.GetAppointments();
            lvDataBinding77.ItemsSource = operations;
            lvDataBinding78.ItemsSource = appointments;

        }
    }
}
