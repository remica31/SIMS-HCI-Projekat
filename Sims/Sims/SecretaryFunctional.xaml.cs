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
    /// Interaction logic for SecretaryFunctional.xaml
    /// </summary>
    public partial class SecretaryFunctional : Window
    {
        public SecretaryFunctional()
        {
            InitializeComponent();
        }

        private void Create_Patient(object sender, RoutedEventArgs e)
        {
            CreatePatient c = new CreatePatient();
            c.Show();
            this.Close();
            
        }

        private void Delete_Patient(object sender, RoutedEventArgs e)
        {
            RemovePatient r = new RemovePatient();
            this.Close();
            r.Show();

        }

        private void Update_Patient(object sender, RoutedEventArgs e)
        {
            UpdatePatient u = new UpdatePatient();
            this.Close();
            u.Show();

        }

        private void View_Patients(object sender, RoutedEventArgs e)
        {
            PagePatient p = new PagePatient();
            var host = new Window();
            host.Content = p;
            host.Show();
        }
    }
}
