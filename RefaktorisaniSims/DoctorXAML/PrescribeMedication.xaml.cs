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
    /// Interaction logic for PrescribeMedication.xaml
    /// </summary>
    public partial class PrescribeMedication : Window
    {
        App application;
        List<Appointment> appointments = new List<Appointment>();
        Doctor doc = new Doctor();
        List<Medicine> medicines = new List<Medicine>();
        List<Receipt> receipts;
        public PrescribeMedication()
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

        private void translate_Click(object sender, RoutedEventArgs e)
        {
            PrepisiLek p = new PrepisiLek();
            p.Show();
            this.Close();
        }


        private void Info_Click(object sender, RoutedEventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Close();
        }

       
        private void Termin_Click(object sender, RoutedEventArgs e)
        {
            Appointments a = new Appointments();
            a.Show();
            this.Close();
        }

        private void Approve_Click(object sender, RoutedEventArgs e)
        {
            Approve a = new Approve();
            a.Show();
            this.Close();
        }

        private void Prescribe(object sender, RoutedEventArgs e)
        {
            int id = receipts.Count + 1;
            string idd = Convert.ToString(id);
            var med = (Medicine)lvDataBinding.SelectedItem;
            var app = application.appointmentController.GetById(application.app_id);
            var newReceipt = new Receipt(idd, app.patient.User.Id, instruction.Text, Convert.ToInt32(quantity.Text), application.id);
            newReceipt.Medicines.Add(med);
            application.receiptController.Save(newReceipt);

        }
    }
}
