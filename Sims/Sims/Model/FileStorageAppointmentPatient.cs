
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
        string filePath = @"C:\Users\Asus\Desktop\sims5\Sims\Sims\Data\user.txt";
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
        string filePath1 = @"C:\Users\Asus\Desktop\sims5\Sims\Sims\Data\appointment.txt";
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