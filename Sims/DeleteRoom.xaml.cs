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
    /// Interaction logic for DeleteRoom.xaml
    /// </summary>
    public partial class DeleteRoom : Window
    {
        public DeleteRoom()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            WardenFunctional w = new WardenFunctional();
            w.Show();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            FileStorageRoom storage = new FileStorageRoom();
            storage.deleteRoom(Convert.ToInt32(textBox1.Text));
            storage.write();
            this.Close();
            WardenFunctional w = new WardenFunctional();
            w.Show();
        }
    }
}
