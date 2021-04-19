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
    /// Interaction logic for DoctorFunctional.xaml
    /// </summary>
    public partial class DoctorFunctional : Window
    {
        public DoctorFunctional()
        {
            InitializeComponent();
            
        }

        private void Add_Appointment(object sender, RoutedEventArgs e)
        {
            AddAppointment a = new AddAppointment();
            this.Close();
            a.Show();
        }

        private void View_Appointments(object sender, RoutedEventArgs e)
        {
            PageAppointment p = new PageAppointment();
            var host = new Window();
            host.Content = p;
            host.Show();
            //d.Show();
        }

        private void Cancel_Appointment(object sender, RoutedEventArgs e)
        {
            CancelApp c = new CancelApp();
            this.Close();
            c.Show();
        }

        private void Update_Appointment(object sender, RoutedEventArgs e)
        {
            UpdateApp u = new UpdateApp();
            this.Close();
            u.Show();
        }
    }
}
