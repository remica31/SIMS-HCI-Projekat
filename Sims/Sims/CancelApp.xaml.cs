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
    /// Interaction logic for CancelApp.xaml
    /// </summary>
    public partial class CancelApp : Window
    {
        public CancelApp()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
          //  DoctorFunctional d = new DoctorFunctional();
            this.Close();
          //  d.Show();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            FileStorageAppointmentDoctor storage = new FileStorageAppointmentDoctor();
            storage.cancelApp(textBox1.Text);
            storage.write();
           // DoctorFunctional d = new DoctorFunctional();
            this.Close();
          //  d.Show();
        }
    }
}
