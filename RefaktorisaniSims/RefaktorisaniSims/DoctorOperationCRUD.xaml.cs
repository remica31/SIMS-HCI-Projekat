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
    /// Interaction logic for DoctorOperationCRUD.xaml
    /// </summary>
    public partial class DoctorOperationCRUD : Window
    {
        App application;
        List<Operation> operations = new List<Operation>();
        public DoctorOperationCRUD()
        {
            InitializeComponent();
            application = Application.Current as App;
            operations = application.operationController.GetAll();
        }

        private void Add_operation(object sender, RoutedEventArgs e)
        {
            var doc = application.doctorController.GetById(textBox5.Text);
            var pat = application.patientController.GetById(textBox6.Text);
            Operation o = new Operation(textBox1.Text, (DateTime)datum.SelectedDate, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), doc, pat);
            application.operationController.Save(o);
        }

        private void View_operations(object sender, RoutedEventArgs e)
        {
            operations = application.operationController.GetAll();
            lvDataBinding.ItemsSource = operations;
        }

        private void Update_operation(object sender, RoutedEventArgs e)
        {
            operations = application.operationController.GetAll();
            foreach (var app in operations)
            {
                if (app.Id == textBox1.Text)
                {
                    var temp1 = app.doctor;
                    var temp2 = app.patient;
                    application.operationController.Delete(app.Id);
                    var updatedApp = new Operation(textBox1.Text, (DateTime)datum.SelectedDate, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), temp1,temp2);
                    application.operationController.Save(updatedApp);
                    break;
                }
            }
        }

        private void Delete_operation(object sender, RoutedEventArgs e)
        {
            operations = application.operationController.GetAll();
            foreach (var app in operations)
            {
                if (app.Id == textBox1.Text)
                {
                    application.operationController.Delete(app.Id);
                    break;
                }
            }
        }
    }
}
