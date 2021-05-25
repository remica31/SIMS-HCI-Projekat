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
    /// Interaction logic for SecretaryNotificationBoard.xaml
    /// </summary>
    public partial class SecretaryNotificationBoard : Window
    {
        App application;
        List<NotificationBoard> notificationBoards = new List<NotificationBoard>();
        public SecretaryNotificationBoard()
        {
            InitializeComponent();
            application = Application.Current as App;
            notificationBoards = application.notificationBoardController.GetAll();

        }

        private void Add(object sender, RoutedEventArgs e)
        {
            
            var id = notificationBoards.Count + 1;
            string idToString = Convert.ToString(id);
            var newNotification = new NotificationBoard(idToString, textBox2.Text, textBox3.Text, DateTime.Now);
            application.notificationBoardController.Save(newNotification);
        }

        private void View(object sender, RoutedEventArgs e)
        {
            notificationBoards = application.notificationBoardController.GetAll();
            lvDataBinding3.ItemsSource = notificationBoards;
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            NotificationBoard temp = (NotificationBoard)lvDataBinding3.SelectedItem;
            application.notificationBoardController.Delete(temp.Id);
        }

        private void Update(object sender, RoutedEventArgs e)
        {
            NotificationBoard temp = (NotificationBoard)lvDataBinding3.SelectedItem;
            foreach(var not in notificationBoards)
            {
                if (not.Id == temp.Id)
                {
                    not.Name = textBox2.Text;
                    not.Text = textBox3.Text;
                    application.notificationBoardController.Update(not);
                }
            }
            
            
        }
    }
}
