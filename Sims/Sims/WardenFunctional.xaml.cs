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
    /// Interaction logic for WardenFunctional.xaml
    /// </summary>
    public partial class WardenFunctional : Window
    {
        public WardenFunctional()
        {
            InitializeComponent();
        }

        private void View_Click(object sender, RoutedEventArgs e)
        {
            PageRooms r = new PageRooms();
            var host = new Window();
            host.Content = r;
            host.Show();
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            AddRoom r = new AddRoom();
            r.Show();
            this.Close();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            UpdateRoom ur = new UpdateRoom();
            ur.Show();
            this.Close();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            DeleteRoom dr = new DeleteRoom();
            dr.Show();
            this.Close();
        }
        private void View_Equipment(object sender, RoutedEventArgs e)
        {
            PageEquipment r = new PageEquipment();
            var host = new Window();
            host.Content = r;
            host.Show();
        }

        private void Create_Equipment(object sender, RoutedEventArgs e)
        {
            CreateEquipment c = new CreateEquipment();
            c.Show();
            this.Close();
        }

        private void Update_Equipment(object sender, RoutedEventArgs e)
        {
            UpdateEquipment u = new UpdateEquipment();
            u.Show();
            this.Close();
        }

        private void Delete_Equipment(object sender, RoutedEventArgs e)
        {
            DeleteEquipment d = new DeleteEquipment();
            d.Show();
            this.Close();

        }
        private void View_Dynamic(object sender, RoutedEventArgs e)
        {
            PageDynamicEq p = new PageDynamicEq();
            var host = new Window();
            host.Content = p;
            host.Show();


        }

        private void Create_Dynamic(object sender, RoutedEventArgs e)
        {
            CreateDynamicEq c = new CreateDynamicEq();
            c.Show();
            this.Close();
        }

        private void Update_Dynamic(object sender, RoutedEventArgs e)
        {
            UpdateDynamicEq u = new UpdateDynamicEq();
            u.Show();
            this.Close();

        }

        private void Delete_Dynamic(object sender, RoutedEventArgs e)
        {
            DeleteDynamicEq d = new DeleteDynamicEq();
            d.Show();
            this.Close();
        }
    }
}
