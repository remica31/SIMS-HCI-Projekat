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
    /// Interaction logic for UpdateRequest.xaml
    /// </summary>
    public partial class UpdateRequest : Window
    {
        public UpdateRequest()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DoctorFunctional d = new DoctorFunctional();
            this.Close();
            d.Show();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            FileStorageRequest storage = new FileStorageRequest();
            storage.updateRequest(textBox1.Text, textBox2.Text, textBox3.Text, int.Parse(textBox4.Text));
            storage.write();
            DoctorFunctional d = new DoctorFunctional();
            this.Close();
            d.Show();
        }
    }
}
