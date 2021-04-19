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
    /// Interaction logic for RemoveRequest.xaml
    /// </summary>
    public partial class RemoveRequest : Window
    {
        public RemoveRequest()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            DoctorFunctional d = new DoctorFunctional();
            this.Close();
            d.Show();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            FileStorageRequest storage = new FileStorageRequest();
            storage.deleteRequest(textBox1.Text);
            storage.write();
            DoctorFunctional d = new DoctorFunctional();
            this.Close();
            d.Show();
        }
    }
}
