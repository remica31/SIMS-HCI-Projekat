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
    /// Interaction logic for DeleteDynamicEq.xaml
    /// </summary>
    public partial class DeleteDynamicEq : Window
    {
        public DeleteDynamicEq()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            WardenFunctional d = new WardenFunctional();
            this.Close();
            d.Show();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Model.FileStorageRoom storage = new Model.FileStorageRoom();
            storage.Read1();
            storage.deleteEquipment1(textBox1.Text);
            storage.write1();
            WardenFunctional d = new WardenFunctional();
            this.Close();
            d.Show();
        }
    }
}
