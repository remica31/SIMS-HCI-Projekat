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
    /// Interaction logic for UpdateOperationsBySecretary.xaml
    /// </summary>
    public partial class UpdateOperationsBySecretary : Window
    {
        public UpdateOperationsBySecretary()
        {
            InitializeComponent();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            FileStorageAppointmentDoctor storage = new FileStorageAppointmentDoctor();
            storage.ReadOperations();
            storage.UpdateOperation(textBox1.Text, Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text), textBox4.Text, textBox5.Text, Convert.ToInt32(textBox6.Text));
            storage.WriteOperations();
            this.Close();
            SecreteryViewSchedule s = new SecreteryViewSchedule();
            s.Show();

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
