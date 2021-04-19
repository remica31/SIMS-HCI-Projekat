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
    /// Interaction logic for PageDynamicRequests.xaml
    /// </summary>
    public partial class PageDynamicRequests : Page
    {
        public PageDynamicRequests()
        {
            InitializeComponent();
            Model.FileStorageDoctor f = new Model.FileStorageDoctor();
            f.ReadRequests();
            List<Model.DinamicEquipmentRequest> requests = f.GetAll();
            lvDataBinding5.ItemsSource = requests;
        }
    }
}
