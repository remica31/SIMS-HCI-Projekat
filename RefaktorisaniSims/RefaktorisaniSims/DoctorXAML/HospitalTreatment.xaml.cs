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

namespace RefaktorisaniSims.DoctorXAML
{
    /// <summary>
    /// Interaction logic for HospitalTreatment.xaml
    /// </summary>
    public partial class HospitalTreatment : Window
    {
        App application;
        List<Room> rooms = new List<Room>();
        Room selectedRoom;
        Appointment app;
        List<HospitalTReatment> tReatments = new List<HospitalTReatment>();
        public HospitalTreatment()
        {
            InitializeComponent();
            application = Application.Current as App;
            rooms = application.roomController.GetByType("Vocation");
            lvDataBinding3.ItemsSource = rooms;
            app = application.appointmentController.GetById(application.app_id);
            tReatments = application.hospitalTreatmentController.GetAll();

        }

        private void Select(object sender, RoutedEventArgs e)
        {
            selectedRoom = (Room)lvDataBinding3.SelectedItem;
            var beds = application.roomController.GetFreeBeds(selectedRoom);
           // var beds = selectedRoom.beds;
            lvDataBinding4.ItemsSource = beds;
        }

        private void Send(object sender, RoutedEventArgs e)
        {
            var selectedBed = (Bed)lvDataBinding4.SelectedItem;//biranje kreveta
            selectedBed.Status = "Taken";
            application.roomController.Update(selectedRoom);

            int id = tReatments.Count + 1;//Dodavanje novog bolnickog lecenja
            DateTime start = (DateTime)dateeee.SelectedDate;
            var finishHelp = start;
            DateTime finish = finishHelp.AddDays(Convert.ToInt32(days.Text));
            HospitalTReatment hospitalTreatment = new HospitalTReatment(id, start, finish, app.patient.User.Id);
            application.hospitalTreatmentController.Save(hospitalTreatment);

            MessageBox.Show("Uspesno poslat pacijent na bolnicko lecenje");

            Appointments a = new Appointments();//menjanje prozora
            a.Show();
            this.Close();
           
            
        }
    }
}
