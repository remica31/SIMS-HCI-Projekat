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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sims
{
    /// <summary>
    /// Interaction logic for PageRoomsxaml.xaml
    /// </summary>
    public partial class PageRooms : Page
    {
        public PageRooms()
        {
            InitializeComponent();

            FileStorageRoom storage = new FileStorageRoom();
            List<Room> rooms= storage.GetRooms();
            lvDataBinding2.ItemsSource = rooms;
        }
    }
}
