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
    /// Interaction logic for AdvancedRenovation.xaml
    /// </summary>
    public partial class AdvancedRenovation : Window
    {
        App application;
        List<Room> rooms = new List<Room>();

        public AdvancedRenovation()
        {
            InitializeComponent();
            application = Application.Current as App;
            Update_ListView();
        }

        public async void Triger_Time()
        {
            await Task.Delay(5000);
        }

        public void Update_ListView()
        {
            rooms = application.roomController.GetAll();
            lvDataBinding.ItemsSource = rooms;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            application.roomController.MergeRooms(txbx1.Text, txbx2.Text);
            Triger_Time();
            Update_ListView();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            application.roomController.SplitRooms(txbx1.Text, txbx2.Text);
            Triger_Time();
            Update_ListView();
        }
    }
}
