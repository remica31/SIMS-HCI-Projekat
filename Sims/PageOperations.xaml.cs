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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sims
{
    /// <summary>
    /// Interaction logic for PageOperations.xaml
    /// </summary>
    public partial class PageOperations : Page
    {
        public PageOperations()
        {
            InitializeComponent();
            FileStorageAppointmentDoctor storage = new FileStorageAppointmentDoctor();
            storage.ReadOperations();
            List<Operations> operations = storage.GetOperations();
            // List<Doctor> operations = storage.getDoctors();
            lvDataBinding5.ItemsSource = operations;
        }
    }
}
