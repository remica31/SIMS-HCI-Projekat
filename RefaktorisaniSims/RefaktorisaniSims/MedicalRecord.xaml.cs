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
    /// Interaction logic for MedicalRecord.xaml
    /// </summary>
    public partial class MedicalRecord : Window
    {


        App applicaton;

        public MedicalRecord()
        {
            InitializeComponent();
            applicaton = Application.Current as App;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Anamnesis> anamneses = new List<Anamnesis>();
            List<Anamnesis> anamnesesToShow = new List<Anamnesis>();
            List<HospitalReferral> hospitalReferrals = new List<HospitalReferral>();
            List<HospitalReferral> hospitalReferralsToShow = new List<HospitalReferral>();
            List<Receipt> receipts = new List<Receipt>();
            List<Receipt> receiptsToShow = new List<Receipt>();



            anamneses = applicaton.anamnesisController.GetAll();
            hospitalReferrals = applicaton.hospitalReferralController.GetAll();
            receipts = applicaton.receiptController.GetAll();

            foreach(var a in anamneses)
            {
                if(a.PatientId == name_id.Text)
                {
                    anamnesesToShow.Add(a);
                }    
            }

            foreach (var a in hospitalReferrals)
            {
                if (a.Patient.User.Id == name_id.Text)
                {
                    hospitalReferralsToShow.Add(a);
                }
            }

            foreach (var a in receipts)
            {
                if (a.PatientID == name_id.Text)
                {
                    receiptsToShow.Add(a);
                }
            }



            anamneza.ItemsSource = anamnesesToShow;
            recept.ItemsSource = receiptsToShow;
            uput.ItemsSource = hospitalReferralsToShow;


        }
    }
}
