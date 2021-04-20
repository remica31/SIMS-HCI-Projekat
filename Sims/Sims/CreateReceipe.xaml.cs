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
    /// Interaction logic for CreateReceipe.xaml
    /// </summary>
    public partial class CreateReceipe : Window
    {
        public CreateReceipe()
        {
            InitializeComponent();
            FileStorageAppointmentDoctor storage = new FileStorageAppointmentDoctor();
            storage.ReadMedicines();
            storage.ReadReceipts();
            List<Medicine> medicines = storage.GetMedicines();
            lvDataBinding5.ItemsSource = medicines;
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            FileStorageAppointmentDoctor storage = new FileStorageAppointmentDoctor();
            storage.ReadMedicines();
            storage.ReadReceipts();
            storage.CreateReceipe(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox1.Text);
            
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
