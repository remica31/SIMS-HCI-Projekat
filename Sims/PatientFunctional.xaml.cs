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
    /// Interaction logic for PatientFunctional.xaml
    /// </summary>
    public partial class PatientFunctional : Window
    {
        public PatientFunctional()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddAppointment_Patient_ a = new AddAppointment_Patient_();
            a.Show();
            this.Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            CancelApp_Patient_ c = new CancelApp_Patient_();
            c.Show();
            this.Close();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            UppAppointment_Patient_ u = new UppAppointment_Patient_();
            u.Show();
            this.Close();
        }

        private void View_Click(object sender, RoutedEventArgs e)
        {
            PageAppointment a = new PageAppointment();
            var host = new Window();
            host.Content = a;
            host.Show();
        }
    }
}
