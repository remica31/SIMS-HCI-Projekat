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
using Model;
namespace RefaktorisaniSims
{
    /// <summary>
    /// Interaction logic for SecretaryDischargeList.xaml
    /// </summary>
    public partial class SecretaryDischargeList : Window
    {
        App application;
        List<DischargeList> discharges = new List<DischargeList>();
        public SecretaryDischargeList()
        {
            InitializeComponent();
            application = Application.Current as App;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<HospitalTReatment> treatments = new List<HospitalTReatment>();//application.hospitalTreatmentController.GetAll();
            List<HospitalTReatment> toShow = new List<HospitalTReatment>();
            treatments= application.hospitalTreatmentController.GetAll();
            DateTime today = DateTime.Now;
            foreach(var treatment in treatments)
            {
                if (treatment.FinishTime.Date == today.Date)
                {
                    toShow.Add(treatment);
                }
            }
            lvDataBinding3.ItemsSource =toShow;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var a = (HospitalTReatment)lvDataBinding3.SelectedItem;
            var pat = application.patientController.GetById(a.PatientID);
            DischargeList dischargeList = new DischargeList(pat.User.Name, pat.User.Surname, a.FinishTime, description.Text);
            discharges.Add(dischargeList);
            application.hospitalTreatmentController.Delete(a.Id);
            lvDataBinding4.ItemsSource = discharges;
        }
    }
}
