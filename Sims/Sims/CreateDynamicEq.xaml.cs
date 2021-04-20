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
    /// Interaction logic for CreateDynamicEq.xaml
    /// </summary>
    public partial class CreateDynamicEq : Window
    {
        public CreateDynamicEq()
        {
            InitializeComponent();
        }

        private void Add(object sender, RoutedEventArgs e)
        {

            Model.FileStorageRoom storage2 = new Model.FileStorageRoom();
            List<Model.DinamicEquipments> equipment = storage2.getAll1();
            // storage2.createRequest("A1", 12, 1, 13);
            storage2.Create1(textBox1.Text, textBox2.Text, textBox3.Text, int.Parse(textBox4.Text));
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
