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
    /// Interaction logic for OdobriLek.xaml
    /// </summary>
    public partial class OdobriLek : Window
    {
        App application;
        List<Medicine> medicines = new List<Medicine>();
        public OdobriLek()
        {
            InitializeComponent();
            application = Application.Current as App;
            medicines = application.medicineController.GetAllByStatus("Waiting");
            lvDataBinding.ItemsSource = medicines;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Approve a = new Approve();
            a.Show();
            this.Close();
        }

        private void select_click(object sender, RoutedEventArgs e)
        {
            var med = (Medicine)lvDataBinding.SelectedItem;
            naziv.Content = med.Name;
            string s = "Description: " + med.Description;
            block.Text = s + ", ingredients: " + med.Ingredients;
        }

        private void Appointments_Click(object sender, RoutedEventArgs e)
        {
            Pregledi p = new Pregledi();
            p.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Pocetna p = new Pocetna();
            p.Show();
            this.Close();
        }

        private void Approve_Click(object sender, RoutedEventArgs e)
        {
            var med2 = (Medicine)lvDataBinding.SelectedItem;
            foreach (var med in medicines)
            {
                if (med.Id == med2.Id)
                {
                    med.Status = "Accepted";
                    application.medicineController.Update(med);
                    medicines = application.medicineController.GetAllByStatus("Waiting");
                    lvDataBinding.ItemsSource = medicines;
                    break;
                }
            }
        }

        private void Reject_Click(object sender, RoutedEventArgs e)
        {
            var med2 = (Medicine)lvDataBinding.SelectedItem;
            foreach (var med in medicines)
            {
                if (med.Id == med2.Id)
                {
                    med.Status = "Reject";
                    application.medicineController.Update(med);
                    medicines = application.medicineController.GetAllByStatus("Waiting");
                    lvDataBinding.ItemsSource = medicines;
                    break;
                }
            }
        }
    }
}
