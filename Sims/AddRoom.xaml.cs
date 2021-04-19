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
    /// Interaction logic for AddRoom.xaml
    /// </summary>
    public partial class AddRoom : Window
    {
        public AddRoom()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            FileStorageRoom storage = new FileStorageRoom();
            storage.createRoom(textBox1.Text, textBox2.Text, textBox3.Text);
            this.Close();
            WardenFunctional w = new WardenFunctional();
            w.Show();

        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            WardenFunctional w = new WardenFunctional();
            w.Show();
        }
    }
}
