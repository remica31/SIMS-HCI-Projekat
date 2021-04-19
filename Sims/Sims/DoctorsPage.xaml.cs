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
    /// Interaction logic for DoctorsPage.xaml
    /// </summary>
    public partial class DoctorsPage : Page
    {
        public DoctorsPage()
        {
            InitializeComponent();


            FileStorageAppointmentDoctor storage = new FileStorageAppointmentDoctor();
            List<Doctor> doctors = storage.getDoctors();
            lvDataBinding.ItemsSource = doctors;
        }

        private void lvDataBinding_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
