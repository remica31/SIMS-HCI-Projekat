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
    /// Interaction logic for DoctorReceipt.xaml
    /// </summary>
    public partial class DoctorReceipt : Window
    {
        App application;
        List<Medicine> medicines;
        List<Receipt> receipts;
        public DoctorReceipt()
        {
            InitializeComponent();
            application = Application.Current as App;
            medicines = new List<Medicine>();
            medicines = application.medicineController.GetAllByStatus("Accepted");
            receipts = application.receiptController.GetAll();
            lvDataBinding3.ItemsSource = medicines;
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            receipts = application.receiptController.GetAll();
            bool exist = false;
            foreach(var r in receipts)
            {
                if (textBox1.Text == r.Id)
                {
                    var temp = r;
                    var med = application.medicineController.GetById(textBox5.Text);
                    application.receiptController.Delete(r.Id);
                    temp.Medicines.Add(med);
                    application.receiptController.Save(temp);
                    exist = true;
                    break;
                }
            }
            if (exist == false)
            {
                var newReceipt = new Receipt(textBox1.Text, textBox4.Text, textBox3.Text, Convert.ToInt32(textBox2.Text), textBox6.Text);
                var med= application.medicineController.GetById(textBox5.Text);
                newReceipt.Medicines.Add(med);
                application.receiptController.Save(newReceipt);
               
            }
            
        }

       
    }
}
