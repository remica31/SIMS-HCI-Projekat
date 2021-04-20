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
    /// Interaction logic for PageDynamicEq.xaml
    /// </summary>
    public partial class PageDynamicEq : Page
    {
        public PageDynamicEq()
        {
            InitializeComponent();
            InitializeComponent();
            Model.FileStorageRoom f = new Model.FileStorageRoom();
            f.Read1();
            List<Model.DinamicEquipments> eq = f.getAll1();
            lvDataBinding2.ItemsSource = eq;
        }
    }
}
