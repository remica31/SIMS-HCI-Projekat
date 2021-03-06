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
            if (CheckEquipmentName(textBox2.Text))
            {
                DynamicEquipmentRequest dr = new DynamicEquipmentRequest();
                dr.Id = textBox1.Text;
                dr.Name = textBox2.Text;
                dr.Status = "WAITING";
                dr.Date = DateTime.Now;
                dr.WardensComment = "/";
                application.dynamicEquipmentRequestController.Save(dr);
            } else
            {
                MessageBox.Show("Invalid equipment name!");
            }
        }
        
        public bool CheckEquipmentName(string name)
        {
            bool exist = true;
            var temp = application.dynamicEquipmentController.GetByName(name);
            if (temp == null)
            {
                exist = false;
            }
            return exist;
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

        private void Search(object sender, RoutedEventArgs e)
        {
            var reqs1 = new List<DynamicEquipmentRequest>();

            if (textBox6.Text != "" && textBox7.Text != "")
            {
                reqs1 = application.dynamicEquipmentRequestController.SearchByNameAndStatus(textBox6.Text, textBox7.Text);
            }
            else if (textBox6.Text != "" && textBox7.Text == "")
            {
                reqs1 = application.dynamicEquipmentRequestController.SearchByName(textBox6.Text);
            }
            else if (textBox6.Text == "" && textBox7.Text != "")
            {
                reqs1 = application.dynamicEquipmentRequestController.SearchByStatus(textBox7.Text);
            }
            else
            {
                MessageBox.Show("Enter search parameters!");
            }

            if (reqs1.Count != 0)
            {
                application.dynamicEquipmentRequestController.SortByDate(reqs1);
                lvDataBinding.ItemsSource = reqs1;
            }
        }
    }
}
