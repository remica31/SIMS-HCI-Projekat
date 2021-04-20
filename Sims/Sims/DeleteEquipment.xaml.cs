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
    /// Interaction logic for DeleteEquipment.xaml
    /// </summary>
    public partial class DeleteEquipment : Window
    {
        public DeleteEquipment()
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
            storage.Read();
            storage.deleteEquipment(textBox1.Text);
            storage.write();
            WardenFunctional d = new WardenFunctional();
            this.Close();
            d.Show();
        }
    }
}
