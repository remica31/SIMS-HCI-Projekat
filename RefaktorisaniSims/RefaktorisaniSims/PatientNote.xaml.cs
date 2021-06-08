using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    /// 


    public partial class PatientNote : Window
    {

        App application;
        List<PatientNotes> notes = new List<PatientNotes>();
        private ObservableCollection<PatientNotes> Items = new ObservableCollection<PatientNotes>();
        Point startPoint = new Point();


        public ObservableCollection<PatientNotes> patientNotes1
        {
            get;
            set;
        }

        public ObservableCollection<PatientNotes> patientNotes2
        {
            get;
            set;
        }




        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }


        private double _test3;

        public double Test3
        {
            get
            {
                return _test3;
            }
            set
            {
                if (value != _test3)
                {
                    _test3 = value;
                    OnPropertyChanged("Test3");
                }
            }
        }

        public PatientNote()
        {
            application = Application.Current as App;
            InitializeComponent();
            this.DataContext = this;
            List<PatientNotes> patientNotes = new List<PatientNotes>();
            patientNotes = application.patientNoteController.GetAll();

            patientNotes1 = new ObservableCollection<PatientNotes>(patientNotes);
            patientNotes2 = new ObservableCollection<PatientNotes>();

            lstView.ItemsSource = patientNotes1;

            //while (true) {
            //Reminder();
            // }

        }

        public async void Reminder(int period)
        {
            await Task.Delay(period * 1000);
            MessageBox.Show("podsetnik");
        }

        

        private void create_note(object sender, RoutedEventArgs e)
        {

            
            var newP = new PatientNotes(box_id.Text, ime.Text, note.Text, int.Parse(period.Text), (DateTime)vreme1.SelectedDate);
            application.k = 1;
            application.patientNoteController.Save(newP);
            Reminder(int.Parse(period.Text));

            

        }


        private void view_notes(object sender, RoutedEventArgs e)
        {
            //   List<PatientNotes> patientNotes = new List<PatientNotes>();

            // patientNotes = application.patientNotesController.GetAll();

            //lstView.ItemsSource = patientNotes;

            List<PatientNotes> patientNotes = new List<PatientNotes>();
            patientNotes = application.patientNoteController.GetAll();

            patientNotes1 = new ObservableCollection<PatientNotes>(patientNotes);
            lstView.ItemsSource = patientNotes1;
        }

        private void Update(object sender, RoutedEventArgs e)
        {
            notes = application.patientNoteController.GetAll();
            foreach (var nt in notes)
            { 
                if(nt.Id == box_id.Text)
                {
                    nt.Name = ime.Text;
                    nt.Period = int.Parse(period.Text);
                    application.patientNoteController.Update(nt);
                }
            }    
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            foreach( var a in patientNotes2)
            {
                application.patientNoteController.Delete(a.Id);
            }

            patientNotes2.Clear();

            lstView2.ItemsSource = patientNotes2;
        }

        // ================================================================ DRAG AND DROP ======================================================================================

        private void ListView_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            startPoint = e.GetPosition(null);
        }

        private void ListView_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePos = e.GetPosition(null);
            Vector diff = startPoint - mousePos;

            if (e.LeftButton == MouseButtonState.Pressed &&
                (Math.Abs(diff.X) > SystemParameters.MinimumHorizontalDragDistance ||
                Math.Abs(diff.Y) > SystemParameters.MinimumVerticalDragDistance))
            {
                // Get the dragged ListViewItem
                ListView listView = sender as ListView;
                ListViewItem listViewItem =
                    FindAncestor<ListViewItem>((DependencyObject)e.OriginalSource);

                if (listViewItem == null) return;

                // Find the data behind the ListViewItem
                PatientNotes patientNotes = (PatientNotes)listView.ItemContainerGenerator.
                    ItemFromContainer(listViewItem);

                // Initialize the drag & drop operation
                DataObject dragData = new DataObject("myFormat", patientNotes);
                DragDrop.DoDragDrop(listViewItem, dragData, DragDropEffects.Move);
            }
        }

        private static T FindAncestor<T>(DependencyObject current) where T : DependencyObject
        {
            do
            {
                if (current is T)
                {
                    return (T)current;
                }
                current = VisualTreeHelper.GetParent(current);
            }
            while (current != null);
            return null;
        }

        private void ListView_DragOver(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent("myFormat") || e.Source == sender)
            {
                e.Effects = DragDropEffects.None;
            }
        }

        private void ListView_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("myFormat"))
            {
                PatientNotes patientNotes = e.Data.GetData("myFormat") as PatientNotes;
                
                patientNotes2.Add(patientNotes);
                patientNotes1.Remove(patientNotes);
                lstView2.ItemsSource = patientNotes2;
            }
        }

    }






}

