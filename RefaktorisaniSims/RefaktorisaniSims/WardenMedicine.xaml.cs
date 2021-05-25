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
    /// Interaction logic for WardenMedicine.xaml
    /// </summary>
    public partial class WardenMedicine : Window
    {
        App applicaton;
        List<Medicine> medicines = new List<Medicine>();

        public WardenMedicine()
        {
            InitializeComponent();
            applicaton = Application.Current as App;
            medicines = applicaton.medicineController.GetAll();
        }

        private void Add_Request(object sender, RoutedEventArgs e)
        {
            var newMedicine = new Medicine(textBox1.Text, textBox2.Text, textBox3.Text, "WAITING", "/", textBox4.Text, textBox5.Text);
            applicaton.medicineController.Save(newMedicine);
        }

        private void View_Requests(object sender, RoutedEventArgs e)
        {
            medicines = applicaton.medicineController.GetAll();
            lvDataBinding.ItemsSource = medicines;
        }

        private void Update_Request(object sender, RoutedEventArgs e)
        {
            medicines = applicaton.medicineController.GetAll();
            foreach (var med in medicines)
            {
                if (textBox1.Text == med.Id)
                {
                    if (med.Status == "Rejected")
                    {
                        med.Description = textBox3.Text;
                        med.Ingredients = textBox4.Text;
                        med.Alternative = textBox5.Text;
                        med.Status = "Waiting";
                        applicaton.medicineController.Update(med);
                    } else
                    {
                        MessageBox.Show("Medicine is not rejected!");
                    }
                    
                }
            }
        }

        private void Delete_Request(object sender, RoutedEventArgs e)
        {
            applicaton.medicineController.Delete(textBox1.Text);
        }
    }
}
