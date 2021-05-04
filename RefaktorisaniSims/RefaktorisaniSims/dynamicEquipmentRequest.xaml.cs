using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RefaktorisaniSims
{
    /// <summary>
    /// Interaction logic for dynamicEquipmentRequest.xaml
    /// </summary>
    public partial class dynamicEquipmentRequest : Window
    {
        App application;
        List<DynamicEquipmentRequest> requests = new List<DynamicEquipmentRequest>();

        public dynamicEquipmentRequest()
        {
            InitializeComponent();
            application = Application.Current as App;
            requests = application.dynamicEquipmentRequestController.GetAll();
        }

        private void Add_Request(object sender, RoutedEventArgs e)
        {
            DynamicEquipmentRequest dr = new DynamicEquipmentRequest();
            dr.Id = textBox1.Text;
            dr.Name = textBox2.Text;
            dr.Status = "WAITING";
            dr.Date = DateTime.Now;
            dr.WardensComment = "/";
            application.dynamicEquipmentRequestController.Save(dr);
        }

        private void View_Requests(object sender, RoutedEventArgs e)
        {
            requests = application.dynamicEquipmentRequestController.GetAll();
            lvDataBinding.ItemsSource = requests;
        }

        private void Update_Request(object sender, RoutedEventArgs e)
        {
            requests = application.dynamicEquipmentRequestController.GetAll();
            foreach (var req in requests)
            {
                if (textBox1.Text == req.Id)
                {
                    var dr = req;
                    if (textBox2.Text != null)
                    {
                        dr.Name = textBox2.Text;
                    }
                    application.dynamicEquipmentRequestController.Delete(req.Id);
                    application.dynamicEquipmentRequestController.Save(dr);
                    break;
                }
            }
        }

        private void Delete_Request(object sender, RoutedEventArgs e)
        {
            application.dynamicEquipmentRequestController.Delete(textBox1.Text);
        }

        private void Manage_Request(object sender, RoutedEventArgs e)
        {
            requests = application.dynamicEquipmentRequestController.GetAll();
            foreach (var req in requests)
            {
                if (textBox1.Text == req.Id)
                {
                    var dr = req;
                    dr.Status = textBox4.Text;
                    dr.WardensComment = textBox5.Text;
                    application.dynamicEquipmentRequestController.Delete(req.Id);
                    application.dynamicEquipmentRequestController.Save(dr);
                    break;
                }
            }
        }
    }
}
