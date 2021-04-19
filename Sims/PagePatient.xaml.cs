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
    /// Interaction logic for PagePatient.xaml
    /// </summary>
    public partial class PagePatient : Page
    {
        public PagePatient()
        {
            InitializeComponent();


            FileStoragePatient storage = new FileStoragePatient();
            List<Patient> patient = storage.GetPatients();
            lvDataBinding3.ItemsSource = patient;
        }
    }
}
