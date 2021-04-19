
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

        private void Add_Request(object sender, RoutedEventArgs e)
        {
            AddRequest r = new AddRequest();
            this.Close();
            r.Show();

        }

        private void View_Requests(object sender, RoutedEventArgs e)
        {
            PageRequest pr = new PageRequest();
            var host = new Window();
            host.Content = pr;
            host.Show();

        }

        private void Cancel_Request(object sender, RoutedEventArgs e)
        {
            RemoveRequest rr = new RemoveRequest();
            this.Close();
            rr.Show();
        }

        private void Update_Request(object sender, RoutedEventArgs e)
        {
            UpdateRequest ur = new UpdateRequest();
            this.Close();
            ur.Show();

        }

        private void View_Dynamic_Requests(object sender, RoutedEventArgs e)
        {
            PageDynamicRequests p = new PageDynamicRequests();
            var host = new Window();
            host.Content = p;
            host.Show();

        }

        private void Create_Dynamic_Request(object sender, RoutedEventArgs e)
        {
            CreateDynamicRequest c = new CreateDynamicRequest();
            this.Close();
            c.Show();

        }

        private void Update_Dynamic_Request(object sender, RoutedEventArgs e)
        {
            UpdateDynamicRequest ud = new UpdateDynamicRequest();
            this.Close();
            ud.Show();
        }

        private void Delete_Dynamic_Request(object sender, RoutedEventArgs e)
        {
            DeleteDynamicRequest dd = new DeleteDynamicRequest();
            this.Close();
            dd.Show();
        }
    }
}
