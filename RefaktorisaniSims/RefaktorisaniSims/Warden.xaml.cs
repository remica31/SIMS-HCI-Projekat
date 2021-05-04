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
    /// Interaction logic for Warden.xaml
    /// </summary>
    public partial class Warden : Window
    {
        public Warden()
        {
            InitializeComponent();
        }

        private void Dyn_Equipment(object sender, RoutedEventArgs e)
        {
            DynEquipment d = new DynEquipment();
            d.Show();
        }

        private void Static_Equipment(object sender, RoutedEventArgs e)
        {
            staticEquipment s = new staticEquipment();
            s.Show();
        }

        private void Rooms(object sender, RoutedEventArgs e)
        {
            rooms r = new rooms();
            r.Show();
        }

        private void Dyn_Transfer(object sender, RoutedEventArgs e)
        {
            DynTransfer d = new DynTransfer();
            d.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RoomRenovations rd = new RoomRenovations();
            rd.Show();
        }
    }
}
