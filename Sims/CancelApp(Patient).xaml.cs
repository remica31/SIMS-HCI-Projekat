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
    /// Interaction logic for CancelApp_Patient_.xaml
    /// </summary>
    public partial class CancelApp_Patient_ : Window
    {
        public CancelApp_Patient_()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            PatientFunctional p = new PatientFunctional();
            this.Close();
            p.Show();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            FileStorageAppointmentPatient storage = new FileStorageAppointmentPatient();
            storage.cancelApp(textBox1.Text);
            storage.write();
            PatientFunctional p = new PatientFunctional();
            this.Close();
            p.Show();
        }
    }
}
