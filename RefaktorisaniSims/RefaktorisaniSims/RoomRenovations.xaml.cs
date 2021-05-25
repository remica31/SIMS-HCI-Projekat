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
    /// Interaction logic for RoomRenovations.xaml
    /// </summary>
    public partial class RoomRenovations : Window
    {
        App application;
        List<BasicRenovation> renovations = new List<BasicRenovation>();

        public RoomRenovations()
        {
            
            InitializeComponent();
            application = Application.Current as App;
            renovations = application.basicRenovationController.GetAll();

        }

        private void Add_Renovation(object sender, RoutedEventArgs e)
        {
            var renovation = new BasicRenovation(textBox1.Text, (DateTime)date.SelectedDate, textBox2.Text);
            application.basicRenovationController.Save(renovation);
        }

        private void View_Renovations(object sender, RoutedEventArgs e)
        {
            renovations = application.basicRenovationController.GetAll();
            lvDataBinding.ItemsSource = renovations;
        }

        private void Update_Renovation(object sender, RoutedEventArgs e)
        {
            foreach (var ren in renovations)
            {
                if (textBox1.Text == ren.Id)
                {
                    ren.Date = (DateTime)date.SelectedDate;
                    application.basicRenovationController.Update(ren);
                    break;
                }
            }
        }

        private void Delete_Renovation(object sender, RoutedEventArgs e)
        {
            application.basicRenovationController.Delete(textBox1.Text);
        }
    }
}
