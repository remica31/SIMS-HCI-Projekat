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
    /// Interaction logic for PageRequest.xaml
    /// </summary>
    public partial class PageRequest : Page
    {
        public PageRequest()
        {
            InitializeComponent();

            FileStorageRequest storage = new FileStorageRequest();
            List<Request> requests = storage.GetRequests();
            lvDataBinding5.ItemsSource = requests;
        }
    }
}
