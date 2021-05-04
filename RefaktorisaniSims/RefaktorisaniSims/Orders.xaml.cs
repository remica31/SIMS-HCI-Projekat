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
using System.Threading;

namespace RefaktorisaniSims
{
    /// <summary>
    /// Interaction logic for Orders.xaml
    /// </summary>
    public partial class Orders : Window
    {
        public DateTime temp = new DateTime(2021, 05, 04, 12, 44, 0);
        App application;
        List<Order> orders = new List<Order>();
        List<DynamicEquipmentRequest> requests = new List<DynamicEquipmentRequest>();

        public Orders()
        {
            InitializeComponent();
            application = Application.Current as App;
            orders = application.orderController.GetAll();
        }

        private void View_Orders(object sender, RoutedEventArgs e)
        {
            orders = application.orderController.GetAll();
            lvDataBinding.ItemsSource = orders;
        }

        private void Add_Order(object sender, RoutedEventArgs e)
        {
            var order = new Order(id.Text, dname.Text, int.Parse(quantity.Text), "SENT", DateTime.Now);
            application.orderController.Save(order);
            MessageBox.Show("Equipment will be delivered as soon as possible!");

            order.Status = "WAITING";
            Thread.Sleep(5000);

            order.Status = "FINISHED";
            application.orderController.Update(order);

            UpdateDynamicEquipment(order);
            
        }

        public void UpdateDynamicEquipment(Order ord)
        {
            var dynamicEquipmentForUpdate = application.dynamicEquipmentController.GetByName(ord.DynamicEquipmentName);
            dynamicEquipmentForUpdate.Quantity += ord.Quantity;
            application.dynamicEquipmentController.Update(dynamicEquipmentForUpdate);
        }

        private void Update_Order(object sender, RoutedEventArgs e)
        {
            foreach (var order in orders)
            {
                if (id.Text == order.Id)
                {
                    order.Quantity = int.Parse(quantity.Text);
                    application.orderController.Update(order);
                }
            }
        }

        private void Delete_Order(object sender, RoutedEventArgs e)
        {
            application.orderController.Delete(id.Text);
        }

        private void View_DynRequests(object sender, RoutedEventArgs e)
        {
            requests = application.dynamicEquipmentRequestController.GetAll();
            lvDataBinding1.ItemsSource = requests;
        }

        private void Search(object sender, RoutedEventArgs e)
        {
            var filteredOrders = new List<Order>();

            if (name.Text != "" && status.Text != "")
            {
                filteredOrders = application.orderController.GetAllByNameAndStatus(name.Text, status.Text);
            }
            else if (name.Text != "" && status.Text == "")
            {
                filteredOrders = application.orderController.GetAllByName(name.Text);
            }
            else if (name.Text == "" && status.Text != "")
            {
                filteredOrders = application.orderController.GetAllByStatus(status.Text);
            }
            else
            {
                MessageBox.Show("Enter search parameters!");
            }
            if (filteredOrders.Count != 0)
            {
                application.orderController.SortByDate(filteredOrders);
                lvDataBinding.ItemsSource = filteredOrders;
            }
        }


    }
}
