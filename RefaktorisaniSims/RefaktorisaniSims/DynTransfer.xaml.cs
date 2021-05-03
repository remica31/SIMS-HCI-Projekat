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
    /// Interaction logic for DynTransfer.xaml
    /// </summary>
    public partial class DynTransfer : Window
    {
        App application;
        List<StaticTransferSchedule> st = new List<StaticTransferSchedule>();

        public DynTransfer()
        {
            InitializeComponent();
            application = Application.Current as App;
        }

        private void Add_Request(object sender, RoutedEventArgs e)
        {
            var newT = new StaticTransferSchedule();
            newT.Id = textBox1.Text;
            newT.EquipmentName = textBox2.Text;
            newT.Quantity = int.Parse(textBox3.Text);
            application.staticTransferScheduleController.Save(newT);
        }

        private void View_Requests(object sender, RoutedEventArgs e)
        {
            st = application.staticTransferScheduleController.GetAll();
            lvDataBinding.ItemsSource = st;
        }

        private void Update_Request(object sender, RoutedEventArgs e)
        {
            st = application.staticTransferScheduleController.GetAll();
            foreach (var eq in st)
            {
                if (eq.Id == textBox1.Text)
                {
                    eq.Quantity = int.Parse(textBox3.Text);
                    application.staticTransferScheduleController.Update(eq);
                }
            }
        }

        private void Delete_Request(object sender, RoutedEventArgs e)
        {
            application.staticTransferScheduleController.Delete(textBox1.Text);
        }
    }
}
