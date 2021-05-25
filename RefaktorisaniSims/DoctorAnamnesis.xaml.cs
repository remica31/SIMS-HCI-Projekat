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
    /// Interaction logic for DoctorAnamnesis.xaml
    /// </summary>
    public partial class DoctorAnamnesis : Window
    {
        App application;
        public DoctorAnamnesis()
        {
            InitializeComponent();
            application = Application.Current as App;
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            var newAnamnesis = new Anamnesis(textBox1.Text, textBox2.Text, textBox3.Text, (DateTime)date.SelectedDate, textBox5.Text);
            application.anamnesisController.Save(newAnamnesis);
        }
    }
}
