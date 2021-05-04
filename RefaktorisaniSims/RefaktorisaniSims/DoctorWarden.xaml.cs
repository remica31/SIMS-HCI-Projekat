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
    /// Interaction logic for DoctorWarden.xaml
    /// </summary>
    public partial class DoctorWarden : Window
    {
        public DoctorWarden()
        {
            InitializeComponent();
        }

        private void Holiday_Requests(object sender, RoutedEventArgs e)
        {
            HolidayRequest hr = new HolidayRequest();
            hr.Show();
        }

        private void Dynamic_Equipment_Requests(object sender, RoutedEventArgs e)
        {
            dynamicEquipmentRequest dr = new dynamicEquipmentRequest();
            dr.Show();
        }
    }
}
