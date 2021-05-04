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
using System.Windows.Shapes;

namespace RefaktorisaniSims
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SecretaryCRUDAppAndOp s = new SecretaryCRUDAppAndOp();
            s.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SecretaryAllergens s = new SecretaryAllergens();
            s.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            CreateGuest c = new CreateGuest();
            c.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            SecretaryAppointmentPriority s = new SecretaryAppointmentPriority();
            s.Show();
        }
    }
}
