using Model;
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
    /// Interaction logic for AddOperation.xaml
    /// </summary>
    public partial class AddOperation : Window
    {
        public AddOperation()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            FileStorageAppointmentDoctor storage2 = new FileStorageAppointmentDoctor();
            storage2.ReadOperations();
            List<Operations> operations = storage2.GetOperations();
            storage2.CreateOperation(textBox1.Text, Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text), textBox4.Text, textBox5.Text,Convert.ToInt32(textBox6.Text));
            storage2.WriteOperations();
            this.Close();

            
        }
    }
}
