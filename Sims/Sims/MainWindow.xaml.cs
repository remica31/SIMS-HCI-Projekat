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

            FileStorageAppointmentDoctor storage = new FileStorageAppointmentDoctor();
            List<Doctor> doctors = storage.getDoctors();
            lvDataBinding.ItemsSource = doctors;

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
        }




    }
}
