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

namespace RefaktorisaniSims.DoctorXAML
{
    /// <summary>
    /// Interaction logic for PrepisiLek.xaml
    /// </summary>
    public partial class PrepisiLek : Window
    {
        App application;
        List<Appointment> appointments = new List<Appointment>();
        Doctor doc = new Doctor();
        List<Medicine> medicines = new List<Medicine>();
        List<Receipt> receipts;
        public PrepisiLek()
        {
            InitializeComponent();
            application = Application.Current as App;
            doc = application.doctorController.GetById(application.id);
            appointments = application.appointmentController.GetByDoctorId(application.id);
            receipts = application.receiptController.GetAll();
            medicines = application.medicineController.GetAllByStatus("Accepted");
            lvDataBinding.ItemsSource = medicines;
            appId.Content = application.app_id;
        }

        private void Prescribe(object sender, RoutedEventArgs e)
        {
            bool pamti = false;
            
            string iD = application.ConvertToId(receipts.Count);
            var med = (Medicine)lvDataBinding.SelectedItem;
            var app = application.appointmentController.GetById(application.app_id);

            var allergens = application.allergenController.GetAll();

            var lista=med.Ingredients.Split(',');
            foreach (var a in allergens)
            {
                foreach(var s in lista)
                {
                    if (app.patient.User.Id == a.PatientId && a.Name == s)
                    {
                        MessageBox.Show("Pacijent je alergican na ovaj lek");
                        pamti = true;
                        break;

                    }
                }
            }

            if (pamti == false) 
            {
                var newReceipt = new Receipt(iD, app.patient.User.Id, instruction.Text, Convert.ToInt32(quantity.Text), application.id);
                newReceipt.Medicines.Add(med);
                application.receiptController.Save(newReceipt);
                MessageBox.Show("Uspesno prepisan recept");

            }
           
        }

      

        private void info_click(object sender, RoutedEventArgs e)
        {
            Pocetna p = new Pocetna();
            p.Show();
            this.Close();
        }

        private void Odobri_Click(object sender, RoutedEventArgs e)
        {
            OdobriLek o = new OdobriLek();
            o.Show();
            this.Close();
        }

        private void translate_Click(object sender, RoutedEventArgs e)
        {
            PrescribeMedication p = new PrescribeMedication();
            p.Show();
            this.Close();
        }

        private void Termin(object sender, RoutedEventArgs e)
        {
            Pregledi p = new Pregledi();
            p.Show();
            this.Close();
        }
    }
}
