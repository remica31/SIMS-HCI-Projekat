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
    /// Interaction logic for UppAppointment_Patient_.xaml
    /// </summary>
    public partial class UppAppointment_Patient_ : Window
    {
        public UppAppointment_Patient_()
        {
            InitializeComponent();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            FileStorageAppointmentPatient storage = new FileStorageAppointmentPatient();
            storage.updateApp(textBox1.Text, Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text));
            storage.write();
            PatientFunctional p = new PatientFunctional();
            this.Close();
            p.Show();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            PatientFunctional p = new PatientFunctional();
            this.Close();
            p.Show();
        }
    }
}
