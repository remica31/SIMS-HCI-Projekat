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
    /// Interaction logic for staticEquipment.xaml
    /// </summary>
    public partial class staticEquipment : Window
    {
        App application;
        List<StaticEquipment> stateq = new List<StaticEquipment>();

        public staticEquipment()
        {
            InitializeComponent();
            application = Application.Current as App;
            stateq = application.staticEquipmentController.GetAll();
        }

        private void Add_Request(object sender, RoutedEventArgs e)
        {
            var eq = new StaticEquipment();
            eq.Id = textBox1.Text;
            eq.Name = textBox2.Text;
            eq.Quantity = int.Parse(textBox3.Text);
            eq.RoomId = textBox4.Text;
            application.staticEquipmentController.Save(eq);
        }

        private void View_Requests(object sender, RoutedEventArgs e)
        {
            stateq = application.staticEquipmentController.GetAll();
            lvDataBinding.ItemsSource = stateq;
        }

        private void Delete_Request(object sender, RoutedEventArgs e)
        {
            application.staticEquipmentController.Delete(textBox1.Text);
        }

        private void Update_Request(object sender, RoutedEventArgs e)
        {
            stateq = application.staticEquipmentController.GetAll();
            foreach (var eq in stateq)
            {
                if (textBox1.Text == eq.Id)
                {
                    var temp = eq;
                    temp.Quantity = int.Parse(textBox3.Text);
                    temp.RoomId = textBox4.Text;
                    application.staticEquipmentController.Delete(eq.Id);
                    application.staticEquipmentController.Save(temp);
                    break;
                }
            }
        }
    }
}
