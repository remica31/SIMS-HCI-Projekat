using Model;
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
    /// Interaction logic for CreateEquipment.xaml
    /// </summary>
    public partial class CreateEquipment : Window
    {
        public CreateEquipment()
        {
            InitializeComponent();
        }

        private void Add(object sender, RoutedEventArgs e)
        {

            Model.FileStorageRoom storage2 = new Model.FileStorageRoom();
            List<StaticEquipments> equipment = storage2.getAll();
            // storage2.createRequest("A1", 12, 1, 13);
            storage2.Create(textBox1.Text, textBox2.Text, textBox3.Text, int.Parse(textBox4.Text));
            WardenFunctional d = new WardenFunctional();
            d.Show();
            this.Close();

        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            WardenFunctional d = new WardenFunctional();
            d.Show();
            this.Close();
        }
    }
}
