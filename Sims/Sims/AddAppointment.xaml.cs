using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Sims
{
    /// <summary>
    /// Interaction logic for AddAppointment.xaml
    /// </summary>
    public partial class AddAppointment : Window
    {
        public AddAppointment()
        {
            InitializeComponent();
            
        }

        private void Add(object sender, RoutedEventArgs e)
        {

            FileStorageAppointmentDoctor storage2 = new FileStorageAppointmentDoctor();
            List<Doctor> doctors = storage2.getDoctors();
            FileStoragePatient storage3 = new FileStoragePatient();
            List<Patient> patient = storage3.GetPatients();
            // storage2.createApp("A1", 12, 1, 13);
            storage2.createApp(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
          /*  string filePath1 = @"C:\Users\User\Downloads\kt\sims5\Sims\Sims\Data\appointment.txt";
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath1).ToList();
            string id = textBox1.Text;//"A1";
            string start = textBox2.Text;//"12";
            string duration = textBox3.Text;//"1";
            string finish = textBox4.Text;//"13";
            string s10 = id + "," + start + "," + duration + ",1," + finish +",d1," +"p2";
            lines.Add(s10);
            File.WriteAllLines(filePath1, lines);*/
            this.Close();


            
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            DoctorFunctional d = new DoctorFunctional();
            d.Show();
            this.Close();
        }
    }
}
