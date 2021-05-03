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
    /// Interaction logic for DynEquipment.xaml
    /// </summary>
    public partial class DynEquipment : Window
    {
        App application;
        List<DynamicEquipment> dyneq = new List<DynamicEquipment>();

        public DynEquipment()
        {
            InitializeComponent();
            application = Application.Current as App;
            dyneq = application.dynamicEquipmentController.GetAll();
        }

        private void View_Requests(object sender, RoutedEventArgs e)
        {
            dyneq = application.dynamicEquipmentController.GetAll();
            lvDataBinding.ItemsSource = dyneq;

        }

        private void Add_Request(object sender, RoutedEventArgs e)
        {
            var dyneq = new DynamicEquipment();
            dyneq.Id = textBox1.Text;
            dyneq.Name = textBox2.Text;
            dyneq.WarehouseId = textBox4.Text;
            dyneq.Quantity = int.Parse(textBox3.Text);
            application.dynamicEquipmentController.Save(dyneq);
        }

        private void Update_Request(object sender, RoutedEventArgs e)
        {
            dyneq = application.dynamicEquipmentController.GetAll();
            foreach (var eq in dyneq)
            {
                if (textBox1.Text == eq.Id)
                {
                    /*
                    var temp = eq;
                    temp.Quantity = int.Parse(textBox3.Text);
                    temp.WarehouseId = textBox4.Text;
                    application.dynamicEquipmentController.Delete(eq.Id);
                    application.dynamicEquipmentController.Save(temp);
                    break;*/
                    eq.Quantity = int.Parse(textBox3.Text);
                    eq.WarehouseId = textBox4.Text;
                    application.dynamicEquipmentController.Update(eq);
                }
            }
        }

        private void Delete_Request(object sender, RoutedEventArgs e)
        {
            application.dynamicEquipmentController.Delete(textBox1.Text);
        }
    }
}
