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
    /// Interaction logic for PageEquipment.xaml
    /// </summary>
    public partial class PageEquipment : Page
    {
        public PageEquipment()
        {
            InitializeComponent();
            Model.FileStorageRoom f = new Model.FileStorageRoom();
            f.Read();
            List<Model.StaticEquipments> eq = f.getAll();
            lvDataBinding2.ItemsSource = eq;
        }
    }
}
