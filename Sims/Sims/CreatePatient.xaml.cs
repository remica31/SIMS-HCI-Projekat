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
    /// Interaction logic for CreatePatient.xaml
    /// </summary>
    public partial class CreatePatient : Window
    {
        public CreatePatient()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            SecretaryFunctional s = new SecretaryFunctional();
            s.Show();
            this.Close();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            FileStoragePatient storage = new FileStoragePatient();
            storage.Create(textBox2.Text, textBox3.Text, textBox4.Text, textBox1.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text);
            
            SecretaryFunctional s = new SecretaryFunctional();
            s.Show();
            this.Close();
        }
    }
}
