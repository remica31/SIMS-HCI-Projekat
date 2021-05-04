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

namespace RefaktorisaniSims
{
    /// <summary>
    /// Interaction logic for DoctorCreateHospitalReferral.xaml
    /// </summary>
    public partial class DoctorCreateHospitalReferral : Window
    {
        App application;
        List<HospitalReferral> referrals = new List<HospitalReferral>();
        
        public DoctorCreateHospitalReferral()
        {
            InitializeComponent();
            application = Application.Current as App;
            referrals = application.hospitalReferralController.GetAll();
           
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            var idInt = referrals.Count + 1;
            var id = Convert.ToString(idInt);
            var patient = application.patientController.GetById(patientId.Text);
            HospitalReferral newReferral = new HospitalReferral(id, fromIdD.Text, toIdD.Text, explanation.Text, patient);
            application.hospitalReferralController.Save(newReferral);
        }

        private void Search_Doctors(object sender, RoutedEventArgs e)
        {
            List<Doctor> doctorsBySpecialization = new List<Doctor>();
            doctorsBySpecialization = application.doctorController.GetBySpeacialization(specializationType.Text);
            lvDataBinding.ItemsSource = doctorsBySpecialization;

        }

        private void Show(object sender, RoutedEventArgs e)
        {
            List<HospitalReferral> referrals = application.hospitalReferralController.GetAll();
            lvDataBinding_Show.ItemsSource = referrals;
        }
    }
}
