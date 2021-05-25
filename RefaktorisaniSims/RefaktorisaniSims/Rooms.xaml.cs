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
    /// Interaction logic for rooms.xaml
    /// </summary>
    public partial class rooms : Window
    {
        App application;
        List<Room> roooms = new List<Room>();

        public rooms()
        {
            InitializeComponent();
            application = Application.Current as App;
            roooms = application.roomController.GetAll();
          
        }

        private void Add_Request(object sender, RoutedEventArgs e)
        {
            var newRoom = new Room();
            newRoom.Id = textBox1.Text;
            newRoom.Number = int.Parse(textBox2.Text);
            newRoom.Floor = int.Parse(textBox3.Text);
            newRoom.Description = textBox4.Text;
            newRoom.Type = textBox5.Text;
            application.roomController.Save(newRoom);
        }

        private void View_Requests(object sender, RoutedEventArgs e)
        {
            roooms = application.roomController.GetAll();
            lvDataBinding.ItemsSource = roooms;
        }

        private void Update_Request(object sender, RoutedEventArgs e)
        {
            foreach (var r in roooms)
            {
                if (r.Id == textBox1.Text)
                {
                    r.Type = textBox5.Text;
                    r.Number = int.Parse(textBox2.Text);
                    application.roomController.Update(r);
                }
            }
        }

        private void Delete_Request(object sender, RoutedEventArgs e)
        {
            application.roomController.Delete(textBox1.Text);
        }
    }
}
