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
    /// Interaction logic for PatientSurvey.xaml
    /// </summary>
    public partial class PatientSurvey : Window
    {
        App application;
        public PatientSurvey()
        {
            InitializeComponent();
            application = Application.Current as App;
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            bool hasAppointment = false;
            var rateH = Convert.ToInt32(textBox4.Text);
            var rateD = Convert.ToInt32(textBox5.Text);
            var patient =application.patientController.GetById(textBox2.Text);
            var apps = application.appointmentController.GetAll();
            foreach(var app in apps)
            {
                if (app.patient.User.Id == patient.User.Id)
                {
                    hasAppointment = true;
                    break;
                }
            }
            if (hasAppointment == false)
            {
                MessageBox.Show("You can't add survey bcs u don't have appointments in your history");
            }
            else
            {
                var survey = new Survey(textBox1.Text, textBox2.Text, textBox3.Text, rateH, rateD, textBox5.Text);
                application.surveyController.Save(survey);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var surveys = application.surveyController.GetAll();
            lvDataBinding2.ItemsSource = surveys;
        }
    }
}
