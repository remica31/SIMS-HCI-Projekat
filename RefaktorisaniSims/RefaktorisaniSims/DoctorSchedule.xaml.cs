using Model;
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
    /// Interaction logic for DoctorSchedule.xaml
    /// </summary>
    public partial class DoctorSchedule : Window
    {
        App application;
        List<Appointment> appointments;
        List<Operation> operations;
        public DoctorSchedule()
        {
            InitializeComponent();
            application = Application.Current as App;
            appointments = new List<Appointment>();
            operations = new List<Operation>();
            
        }

        private void View_Schedule(object sender, RoutedEventArgs e)
        {
            operations = application.operationController.GetByDoctorId(textBox1.Text);
            appointments = application.appointmentController.GetByDoctorId(textBox1.Text);
            lvDataBinding3.ItemsSource = appointments;
            lvDataBinding2.ItemsSource = operations;
          
        }

        private void View_Patient(object sender, RoutedEventArgs e)
        {
            var pat = application.patientController.GetById(textBox2.Text);
            
            label1.Visibility = Visibility.Visible;
            label2.Visibility = Visibility.Visible;
            label3.Visibility = Visibility.Visible;
            label4.Visibility = Visibility.Visible;
            label6.Visibility = Visibility.Visible;
            label7.Visibility = Visibility.Visible;
            label8.Visibility = Visibility.Visible;
            label9.Visibility = Visibility.Visible;
            label10.Visibility = Visibility.Visible;
            label12.Visibility = Visibility.Visible;
            label20.Visibility = Visibility.Visible;
           

            label2.Content = pat.User.Name;
            label1.Content = pat.User.Surname;
            label3.Content = pat.User.DateOfBirth;
            label4.Content = pat.User.Address;
            


        }
    }
}
