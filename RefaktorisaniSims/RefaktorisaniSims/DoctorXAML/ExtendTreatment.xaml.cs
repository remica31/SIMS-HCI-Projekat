using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RefaktorisaniSims.DoctorXAML
{
    /// <summary>
    /// Interaction logic for ExtendTreatment.xaml
    /// </summary>
    public partial class ExtendTreatment : Window
    {
        App application;
        List<HospitalTReatment> treatments = new List<HospitalTReatment>();
        public ExtendTreatment()
        {
            InitializeComponent();
            application = Application.Current as App;
            treatments = application.hospitalTreatmentController.GetAll();
            lvDataBinding3.ItemsSource = treatments;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedTreatment = (HospitalTReatment)lvDataBinding3.SelectedItem;
           
            application.hospitalTreatmentController.Extend(selectedTreatment.Id, Convert.ToInt32(days.Text));
           
            MessageBox.Show("Uspesno produzen boravak pacijenta");

            this.Close();
            Appointments a = new Appointments();
            a.Show();
        }
    }
}
