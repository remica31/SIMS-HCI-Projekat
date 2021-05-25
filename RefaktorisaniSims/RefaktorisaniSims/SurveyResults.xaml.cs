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
    /// Interaction logic for SurveyResults.xaml
    /// </summary>
    public partial class SurveyResults : Window
    {
        App application;
        List<Survey> surveys = new List<Survey>();
        
        public SurveyResults()
        {
            InitializeComponent();
            application = Application.Current as App;
            surveys = application.surveyController.GetAll();
        }

        private void View_Results(object sender, RoutedEventArgs e)
        {
            surveys = application.surveyController.GetAll();
            lvDataBinding2.ItemsSource = surveys;
        }

        private void Hospital_Rates(object sender, RoutedEventArgs e)
        {
            surveys = application.surveyController.GetAll();
            double averageHospitalRate = application.surveyController.CountAverageHospitalRate();
            int ones = application.surveyController.CountHospitalRates(1);
            int twos = application.surveyController.CountHospitalRates(2);
            int threes = application.surveyController.CountHospitalRates(3);
            int fours = application.surveyController.CountHospitalRates(4);
            int fives = application.surveyController.CountHospitalRates(5);

            textBox7.Text = averageHospitalRate.ToString();
            textBox2.Text = ones.ToString();
            textBox3.Text = twos.ToString();
            textBox4.Text = threes.ToString();
            textBox5.Text = fours.ToString();
            textBox6.Text = fives.ToString();
            textBox8.Text = "";

        }

        private void Doctor_Rates(object sender, RoutedEventArgs e)
        {
            surveys = application.surveyController.GetAll();
            double averageDoctorRate = application.surveyController.CountAverageDoctorRate(textBox1.Text);
            int ones = application.surveyController.CountDoctorRates(textBox1.Text, 1);
            int twos = application.surveyController.CountDoctorRates(textBox1.Text, 2);
            int threes = application.surveyController.CountDoctorRates(textBox1.Text, 3);
            int fours = application.surveyController.CountDoctorRates(textBox1.Text, 4);
            int fives = application.surveyController.CountDoctorRates(textBox1.Text, 5);

            textBox8.Text = averageDoctorRate.ToString();
            textBox2.Text = ones.ToString();
            textBox3.Text = twos.ToString();
            textBox4.Text = threes.ToString();
            textBox5.Text = fours.ToString();
            textBox6.Text = fives.ToString();
            textBox7.Text = "";
        }
    }
}
