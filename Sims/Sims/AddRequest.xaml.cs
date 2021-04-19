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
    /// Interaction logic for AddRequest.xaml
    /// </summary>
    public partial class AddRequest : Window
    {
        public AddRequest()
        {
            InitializeComponent();
        }

        private void Add(object sender, RoutedEventArgs e)
        {

            FileStorageRequest storage2 = new FileStorageRequest();
            List<Request> requests = storage2.GetRequests();
            // storage2.createRequest("A1", 12, 1, 13);
            storage2.createRequest(textBox1.Text, textBox2.Text, textBox3.Text, int.Parse(textBox4.Text));
            DoctorFunctional d = new DoctorFunctional();
            d.Show();
            this.Close();

        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            DoctorFunctional d = new DoctorFunctional();
            d.Show();
            this.Close();
        }
    }
}
