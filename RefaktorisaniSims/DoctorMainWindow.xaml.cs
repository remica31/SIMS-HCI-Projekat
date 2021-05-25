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
    /// Interaction logic for DoctorMainWindow.xaml
    /// </summary>
    public partial class DoctorMainWindow : Window
    {
        App application;
        public DoctorMainWindow()
        {
            InitializeComponent();
            application = Application.Current as App;
            label.Content = application.id;
            var notificationsAppointment = application.appointmentNotificationController.GetAll();
            var date = DateTime.Now;
            date.AddDays(1);
            foreach (var a in notificationsAppointment)
            {
                if (date > a.Date)
                {
                    MessageBox.Show(a.Description);
                }
            }

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DoctorAppointmentCRUD d = new DoctorAppointmentCRUD();
            d.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DoctorOperationCRUD d = new DoctorOperationCRUD();
            d.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DoctorSchedule d = new DoctorSchedule();
            d.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            DoctorReceipt d = new DoctorReceipt();
            d.Show();
        }

        private void Anamnesis(object sender, RoutedEventArgs e)
        {
            DoctorAnamnesis d = new DoctorAnamnesis();
            d.Show();
        }

        private void Update_Medicines(object sender, RoutedEventArgs e)
        {
            DoctorMedicinesUpdate d = new DoctorMedicinesUpdate();
            d.Show();
        }

        private void Send_Patient(object sender, RoutedEventArgs e)
        {
            DoctorCreateHospitalReferral d = new DoctorCreateHospitalReferral();
            d.Show();
        }
    }
}
