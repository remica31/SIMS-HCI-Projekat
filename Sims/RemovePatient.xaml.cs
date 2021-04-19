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
    /// Interaction logic for RemovePatient.xaml
    /// </summary>
    public partial class RemovePatient : Window
    {
        public RemovePatient()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            SecretaryFunctional s = new SecretaryFunctional();
            this.Close();
            s.Show();
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            FileStoragePatient storage = new FileStoragePatient();
            storage.deletePatient(textBox1.Text);
            storage.write();
            SecretaryFunctional s = new SecretaryFunctional();
            this.Close();
            s.Show();
        }
    }
}
