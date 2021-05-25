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
    /// Interaction logic for StaticTransfer.xaml
    /// </summary>
    public partial class StaticTransfer : Window
    {
        App application;
        List<NotificationBoard2> transfers = new List<NotificationBoard2>();

        public StaticTransfer()
        {
            InitializeComponent();
            application = Application.Current as App;
            transfers = application.notificationBoardController2.GetAll();
        }

        private void View_Requests(object sender, RoutedEventArgs e)
        {
            transfers = application.notificationBoardController2.GetAll();
            lvDataBinding.ItemsSource = transfers;
        }

        private void Add_Request(object sender, RoutedEventArgs e)
        {
            var transfer = new NotificationBoard2(textBox1.Text, textBox2.Text, textBox3.Text, (DateTime)date.SelectedDate, textBox4.Text);
            application.notificationBoardController2.Save(transfer);

        }

        private void Update_Request(object sender, RoutedEventArgs e)
        {
            transfers = application.notificationBoardController2.GetAll();
            foreach (var tr in transfers)
            {
                if (textBox1.Text == tr.Id)
                {
                    tr.FroomRoomId = textBox2.Text;
                    tr.ToRoomId = textBox3.Text;
                    tr.Date = (DateTime)date.SelectedDate;
                    application.notificationBoardController2.Update(tr);
                }
            }
        }

        private void Delete_Request(object sender, RoutedEventArgs e)
        {
            application.notificationBoardController2.Delete(textBox1.Text);
        }
    }
}
