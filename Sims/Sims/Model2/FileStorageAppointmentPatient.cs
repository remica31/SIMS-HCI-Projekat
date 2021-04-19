
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public class FileStorageAppointmentPatient
{
   public FileStorageAppointmentPatient()
    {

        patients = new List<Patient>();
        string filePath = @"C:\Users\Remica\Desktop\rema\Sims\Sims\Data\user.txt";
        List<string> lines = File.ReadAllLines(filePath).ToList();

        foreach (var line in lines)
        {
            var newuser = new User();


            string[] entries = line.Split(',');
            newuser.Jmbg = entries[0];
            newuser.Username = entries[1];
            newuser.Password = entries[2];
            newuser.Id = entries[3];
            newuser.Name = entries[4];
            newuser.Surname = entries[5];
            newuser.EMail = entries[6];
            newuser.Address = entries[7];
            newuser.Phone = entries[8];
            if (newuser.Id[0] == 'p')
            {      
                        var newPatient = new Patient { user = newuser };
                    patients.Add(newPatient);
            }
        }





        appointments = new List<Appointment>();
        string filePath1 = @"C:\Users\Remica\Desktop\rema\Sims\Sims\Data\appointment.txt";
        List<string> lines1 = File.ReadAllLines(filePath1).ToList();

        foreach (var line in lines1)
        {
            var newApp = new Appointment();
            string[] entries = line.Split(',');

            newApp.Id = entries[0];

            newApp.Start = Convert.ToDouble(entries[1]);
            newApp.Duration = Convert.ToDouble(entries[2]);
            String proba = entries[3];
            //newApp.Type = (AppointmentType)Enum.Parse(typeof(AppointmentType), proba);
            newApp.Finish = Convert.ToDouble(entries[4]);
            String docId = entries[5];
            String patientId = entries[6];
            foreach (var pat in patients)
            {
                if (pat.user.Id == patientId)
                {
                    newApp.patient = pat;
                }
            }

            appointments.Add(newApp);
        }




    }
    public void write()
    {
        string filePath1 = @"C:\Users\Remica\Desktop\rema\Sims\Sims\Data\appointment.txt";
        List<string> lines = new List<string>();
        foreach (var app in appointments)
        {
            string id = app.Id;//"A1";
            string start = app.Start.ToString();//"12";
            string duration = app.Duration.ToString();//"1";
            string finish = app.Finish.ToString();//"13";
            string s10 = id + "," + start + "," + duration + ",1," + finish + ",d1," + "p2";
            lines.Add(s10);
        }
        File.WriteAllLines(filePath1, lines);
    }
    public void createApp(string newId, string newStart, string newDuration, string newFinish)
    {
        /* Appointment newapp = new Appointment();
         newapp.Id = newId;
         newapp.Start = newStart;
         newapp.Finish = newFinish;
         newapp.Duration = newDuration;
         appointments.Add(newapp);*/
        string filePath1 = @"C:\Users\Remica\Desktop\rema\Sims\Sims\Data\appointment.txt";
        List<string> lines = new List<string>();
        lines = File.ReadAllLines(filePath1).ToList();
        string id = newId;//"A1";
        string start = newStart;//"12";
        string duration = newDuration;//"1";
        string finish = newFinish;//"13";
        string s10 = id + "," + start + "," + duration + ",1," + finish + ",d1," + "p2";
        lines.Add(s10);
        File.WriteAllLines(filePath1, lines);
    }
    public void cancelApp(string newId)
    {
        List<Appointment> newList = new List<Appointment>();
        foreach (var app in appointments)
        {
            if (app.Id != newId)
            {
                newList.Add(app);
            }
        }
        appointments = newList;





    }
    public void updateApp(string newId, double newStart, double newDuration, double newFinish)
    {
        foreach (var app in appointments)
        {
            if (app.Id == newId)
            {
                app.Id = newId;
                app.Start = newStart;
                app.Duration = newDuration;
                app.Finish = newFinish;
            }
        }

    }

    public string FileLocation { get; set; }
    public List<Appointment> appointments;
    public List<Patient> patients;
    public List<Appointment> GetAppointments()
    {
        return appointments;
    }

    public List<Patient> GetPatients()
    {
        return patients;
    }
}