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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sims
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            /* FileStorageAppointmentDoctor storage = new FileStorageAppointmentDoctor();
                   List<Doctor> doctors = storage.getDoctors();
            lvDataBinding.ItemsSource = doctors;*/
            /*
            FileStorageAppointmentPatient storage2 = new FileStorageAppointmentPatient();
            List<Appointment> apps= storage2.GetAppointments();
            lvDataBinding2.ItemsSource = apps;


           FileStoragePatient storage3 = new FileStoragePatient();
            List<Patient> patients2 = storage3.GetPatients();
            lvDataBinding3.ItemsSource = patients2;


            FileStorageRequest storage4 = new FileStorageRequest();
            List<Request> requests = storage4.GetRequests();
            lvDataBinding4.ItemsSource = requests;


            FileStorageRoom storage5 = new FileStorageRoom();
            List<Room> rooms = storage5.GetRooms();
            lvDataBinding5.ItemsSource = rooms;
            */
        }

        private void ShowDoctors_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new DoctorsPage();
        }

        private void ShowRooms_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new PageRooms();
        }

        private void ShowPatient_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new PagePatient();
        }

        private void ShowRequest_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new PageRequest();
        }

        private void ShowApp_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new PageAppointment();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FileStoragePatient storage = new FileStoragePatient();
            List<Patient> patient = storage.GetPatients();
            Main.Content = new PagePatient();
            //var a = new Patient();
        }

        private void Doctor_Click(object sender, RoutedEventArgs e)
        {
            DoctorFunctional d = new DoctorFunctional();
            //  var host = new Window();
            // host.Content = d;
            // host.Show();
            d.Show();
            
            
            
            
            
        }

        private void Warden_Click(object sender, RoutedEventArgs e)
        {
            WardenFunctional w = new WardenFunctional();
            w.Show();
        }

        private void Patient_Click(object sender, RoutedEventArgs e)
        {
            PatientFunctional p = new PatientFunctional();
            p.Show();
        }

        private void Secretary_Click(object sender, RoutedEventArgs e)
        {
            SecretaryFunctional s = new SecretaryFunctional();
            s.Show();
        }
    }
}
