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
    /// Interaction logic for SecretaryCRUDdoctor.xaml
    /// </summary>
    public partial class SecretaryCRUDdoctor : Window
    {
        App application;
        List<Doctor> doctors = new List<Doctor>();
        Doctor selectedDoc;
        public SecretaryCRUDdoctor()
        {
            InitializeComponent();
            application = Application.Current as App;
            doctors = application.doctorController.GetAll();
            lvDataBinding3.ItemsSource = doctors;
        }

        private void Create(object sender, RoutedEventArgs e)
        {
            var newDoctor = new Doctor(name.Text, surname.Text, phone.Text, username.Text, password.Text, email.Text, address.Text, (DateTime)dateOfBirth.SelectedDate, specialization.Text);
            int id = doctors.Count + 1;
            string docID = "d" + Convert.ToString(id);
            newDoctor.User.Id = docID;
            application.doctorController.Save(newDoctor);
           
        }

        private void Update(object sender, RoutedEventArgs e)
        {
            string id = selectedDoc.User.Id;
            application.doctorController.Delete(id);
            var newDoctor = new Doctor(name.Text, surname.Text, phone.Text, username.Text, password.Text, email.Text, address.Text, (DateTime)dateOfBirth.SelectedDate, specialization.Text);
            newDoctor.User.Id = id;
            application.doctorController.Save(newDoctor);
           

        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            application.doctorController.Delete(selectedDoc.User.Id);
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            selectedDoc = (Doctor)lvDataBinding3.SelectedItem;
            name.Text = selectedDoc.User.Name;
            surname.Text = selectedDoc.User.Surname;
            phone.Text = selectedDoc.User.Phone;
            username.Text = selectedDoc.User.Username;
            password.Text = selectedDoc.User.Password;
            email.Text = selectedDoc.User.EMail;
            address.Text = selectedDoc.User.Address;
            specialization.Text = selectedDoc.SpecializationType;
            dateOfBirth.SelectedDate = selectedDoc.User.DateOfBirth;
        }

        private void Show(object sender, RoutedEventArgs e)
        {
            var doctorsNEW = application.doctorController.GetAll();
            lvDataBinding3.ItemsSource = doctorsNEW;
        }
    }
}
