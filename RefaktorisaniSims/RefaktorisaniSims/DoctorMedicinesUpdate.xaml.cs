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
    /// Interaction logic for DoctorMedicinesUpdate.xaml
    /// </summary>
    public partial class DoctorMedicinesUpdate : Window
    {
        App application;
        List<Medicine> medicines = new List<Medicine>();
        public DoctorMedicinesUpdate()
        {
            InitializeComponent();
            application = Application.Current as App;
            
        }

        private void ViewApproved_Click(object sender, RoutedEventArgs e)
        {
            lvDataBinding.ItemsSource = application.medicineController.GetAllByStatus("Accepted");
        }

        private void ViewWaiting_Click(object sender, RoutedEventArgs e)
        {
            lvDataBinding.ItemsSource = application.medicineController.GetAllByStatus("Waiting");
           
        }

       

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if (statusMedicine.Text == "Rejected" && DoctorExplain.Text == "")
            {
                MessageBox.Show("You need to explain why Rejected!");
                return;
            }
            foreach (var med in medicines)
            {
                if (IdMedicine.Text == med.Id)
                {
                    med.Name = nameMedicine.Text;
                    med.Description = descriptionMedicine.Text;
                    med.Ingredients = ingredientsMedicine.Text;
                    med.Status = statusMedicine.Text;
                    med.DoctorComment=DoctorExplain.Text;
                    application.medicineController.Update(med);
                }
            }
            
        }

        private void Select_Click(object sender, RoutedEventArgs e)
        {
            medicines = application.medicineController.GetAll();
            var selectedMedicine = (Medicine)lvDataBinding.SelectedItem;
            nameMedicine.Text = selectedMedicine.Name;
            descriptionMedicine.Text = selectedMedicine.Description;
            ingredientsMedicine.Text = selectedMedicine.Ingredients;
            statusMedicine.Text = selectedMedicine.Status;
            DoctorExplain.Text = "";
            IdMedicine.Text = selectedMedicine.Id;
        }
    }
}
