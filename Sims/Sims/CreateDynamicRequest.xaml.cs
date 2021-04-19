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
    /// Interaction logic for CreateDynamicRequest.xaml
    /// </summary>
    public partial class CreateDynamicRequest : Window
    {
        public CreateDynamicRequest()
        {
            InitializeComponent();
        }

        private void Add(object sender, RoutedEventArgs e)
        {

            Model.FileStorageDoctor storage2 = new Model.FileStorageDoctor();
            List<Model.DinamicEquipmentRequest> requests = storage2.GetAll();
            // storage2.createRequest("A1", 12, 1, 13);
            storage2.createRequest(textBox1.Text, textBox2.Text);
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
