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
    /// Interaction logic for UpdateDynamicRequest.xaml
    /// </summary>
    public partial class UpdateDynamicRequest : Window
    {
        public UpdateDynamicRequest()
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
            Model.FileStorageDoctor f = new Model.FileStorageDoctor();
            f.ReadRequests();
            f.updateRequest(textBox1.Text, textBox2.Text); 
            f.write();
            DoctorFunctional d = new DoctorFunctional();
            this.Close();
            d.Show();
        }
    }
}
