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

        private void Orders(object sender, RoutedEventArgs e)
        {
            Orders o = new Orders();
            o.Show();
        }
<<<<<<< Updated upstream
=======

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            this.Close();
            m.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SurveyResults sr = new SurveyResults();
            sr.Show();
            this.Close();
        }
>>>>>>> Stashed changes
    }
}
