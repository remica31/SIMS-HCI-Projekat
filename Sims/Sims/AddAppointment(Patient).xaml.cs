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
    /// Interaction logic for AddAppointment_Patient_.xaml
    /// </summary>
    public partial class AddAppointment_Patient_ : Window
    {
        public AddAppointment_Patient_()
        {
            InitializeComponent();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            FileStorageAppointmentPatient storage2 = new FileStorageAppointmentPatient();
            // storage2.createApp("A1", 12, 1, 13);
            storage2.createApp(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            PatientFunctional p = new PatientFunctional();
            this.Close();
            p.Show();
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            PatientFunctional p = new PatientFunctional();
            this.Close();
            p.Show();
        }
    }
}
