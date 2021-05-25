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
    /// Interaction logic for PatientNote.xaml
    /// </summary>
    public partial class PatientNote : Window
    {
        App application;


        public PatientNote()
        {
            application = Application.Current as App;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            DateTime vreme =(DateTime)vreme1.SelectedDate;
            var newP = new PatientNotes(id.Text, ime.Text, note.Text, int.Parse(period.Text),vreme );

            application.patientNotesController.Save(newP);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<PatientNotes> patientNotes = new List<PatientNotes>();

            patientNotes = application.patientNotesController.GetAll();

            viewNotes.ItemsSource = patientNotes;
        }
    }
}
