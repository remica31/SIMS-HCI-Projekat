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
    /// Interaction logic for CreateGuest.xaml
    /// </summary>
    public partial class CreateGuest : Window
    {
        App application;
        public CreateGuest()
        {
            InitializeComponent();
            application = Application.Current as App;        
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var guest = new Guest(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            application.guestController.Save(guest);
        }
    }
}
