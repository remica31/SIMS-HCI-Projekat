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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sims
{
    /// <summary>
    /// Interaction logic for PageAppointment.xaml
    /// </summary>
    public partial class PageAppointment : Page
    {
        public PageAppointment()
        {
            InitializeComponent();

            FileStorageAppointmentPatient storage = new FileStorageAppointmentPatient();
            List<Appointment> app = storage.GetAppointments();
           // FileStorageAppointmentDoctor storage2 = new FileStorageAppointmentDoctor();
          //  List<Appointment> app = storage2.GetAppointments();
            lvDataBinding4.ItemsSource = app;
        }
    }
}
