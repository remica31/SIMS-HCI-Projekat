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
using Model;

namespace Sims
{
    /// <summary>
    /// Interaction logic for DeleteDynamicRequest.xaml
    /// </summary>
    public partial class DeleteDynamicRequest : Window
    {
        public DeleteDynamicRequest()
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
            Model.FileStorageDoctor f = new Model.FileStorageDoctor();
            f.ReadRequests();
            f.deleteRequest(textBox1.Text);
            f.write();
            DoctorFunctional d = new DoctorFunctional();
            this.Close();
            d.Show();
        }
    }
}
