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
    /// Interaction logic for Approve.xaml
    /// </summary>
    /// 
    public partial class Approve : Window
    {
        App application;
        List<Medicine> medicines = new List<Medicine>();
        public Approve()
        {
            InitializeComponent();
            application = Application.Current as App;
            medicines = application.medicineController.GetAllByStatus("Waiting");
            lvDataBinding.ItemsSource = medicines;
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
            Appointments a = new Appointments();
            a.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OdobriLek o = new OdobriLek();
            o.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Close();
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
    }
}
