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
    /// Interaction logic for UpdateRoom.xaml
    /// </summary>
    public partial class UpdateRoom : Window
    {
        public UpdateRoom()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            WardenFunctional w = new WardenFunctional();
            w.Show();
            this.Close();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            FileStorageRoom storage = new FileStorageRoom();
            storage.updateRoom(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), textBox3.Text);
            storage.write();
            this.Close();
            WardenFunctional w = new WardenFunctional();
            w.Show();
        }
    }
}
