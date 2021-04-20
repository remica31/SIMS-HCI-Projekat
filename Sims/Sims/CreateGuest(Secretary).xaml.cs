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
    /// Interaction logic for CreateGuest_Secretary_.xaml
    /// </summary>
    public partial class CreateGuest_Secretary_ : Window
    {
        FileStoragePatient storage = new FileStoragePatient();
        public CreateGuest_Secretary_()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           // FileStoragePatient storage = new FileStoragePatient();
            storage.CreateGuest(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            List<Guest> guests = storage.GetGuests();

            lvDataBinding.ItemsSource = guests;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
