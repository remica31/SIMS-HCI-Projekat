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
    /// Interaction logic for HolidayRequest.xaml
    /// </summary>
    public partial class HolidayRequest : Window
    {
        App application;
        //List<Model.HolidayRequest> requests = new List<Model.HolidayRequest>();

        public HolidayRequest()
        {
            InitializeComponent();
            application = Application.Current as App;
            //requests = application.holidayRequestController.GetAll();
        }
        private void Delete_Request(object sender, RoutedEventArgs e)
        {

        }

        private void Add_Request(object sender, RoutedEventArgs e)
        {

        }

        private void View_Requests(object sender, RoutedEventArgs e)
        {

        }

        private void Update_Request(object sender, RoutedEventArgs e)
        {

        }

        private void Manage_Request(object sender, RoutedEventArgs e)
        {


        }
        private void Search(object sender, RoutedEventArgs e)
        {

        }
    }
}
        /*
        private void Delete_Request(object sender, RoutedEventArgs e)
        {
            application.holidayRequestController.Delete(textBox1.Text);
        }

        private void Add_Request(object sender, RoutedEventArgs e)
        {
            Model.HolidayRequest hr = new Model.HolidayRequest();
            hr.Id = textBox1.Text;
            hr.DurationInDays = int.Parse(textBox2.Text);
            hr.Description = textBox3.Text;
            hr.Status = "WAITING";
            hr.DateOfSubmissionRequest = DateTime.Now;
            hr.doctor = null;
            hr.WardensComment = "/";
            hr.StartDate = (DateTime)date.SelectedDate;
            application.holidayRequestController.Save(hr);

        }

        private void View_Requests(object sender, RoutedEventArgs e)
        {
            requests = application.holidayRequestController.GetAll();
            lvDataBinding.ItemsSource = requests;
        }

        private void Update_Request(object sender, RoutedEventArgs e)
        {
            requests = application.holidayRequestController.GetAll();
            foreach (var req in requests)
            {
                if (textBox1.Text == req.Id)
                {
                    var hr = req;

                    if (textBox2.Text != null)
                    {
                        hr.DurationInDays = int.Parse(textBox2.Text);
                    }
                    if (textBox3.Text != null)
                    {
                        hr.Description = textBox3.Text;

                    }
                    if (date.SelectedDate != null)
                    {
                        hr.StartDate = DateTime.Now;
                    }
                                     
                    application.holidayRequestController.Delete(req.Id);
                    application.holidayRequestController.Save(hr);
                    break;
                }
            }
        }

        private void Manage_Request(object sender, RoutedEventArgs e)
        {
            requests = application.holidayRequestController.GetAll();
            foreach (var req in requests)
            {
                if (textBox1.Text == req.Id)
                {
                    var hr = req;
                    hr.Status = textBox4.Text;
                    hr.WardensComment = textBox5.Text;
                    application.holidayRequestController.Delete(req.Id);
                    application.holidayRequestController.Save(hr);
                    break;
                }
            }
        }

        private void Search(object sender, RoutedEventArgs e)
        {
            var reqs = new List<Model.HolidayRequest>();
            if (textBox6.Text == "" && textBox7.Text == "")
            {
                MessageBox.Show("Enter search parameters!");
            }
            else if (textBox6.Text != "" && textBox7.Text == "")
            {
                reqs = application.holidayRequestController.SearchByStatus(textBox6.Text);
            }
            else if (textBox6.Text == "" && textBox7.Text != "")
            {
                reqs = application.holidayRequestController.SearchByDoctorId(textBox7.Text);
            }
            else
            {
                reqs = application.holidayRequestController.SearchByStatusAndDoctorId(textBox6.Text, textBox7.Text);
            }
            if (reqs.Count != 0)
            {
                application.holidayRequestController.SortByDate(reqs);
                lvDataBinding.ItemsSource = reqs;
            }

        }
    }
}*/
