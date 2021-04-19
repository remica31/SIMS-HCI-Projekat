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
    }
}
