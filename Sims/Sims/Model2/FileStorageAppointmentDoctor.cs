

using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public class FileStorageAppointmentDoctor
{
    public FileStorageAppointmentDoctor()
    {
        patients = new List<Patient>();
        receipts = new List<Receipt>();
        doctors = new List<Doctor>();
        operations = new List<Operations>();
        medicines = new List<Medicine>();
        string filePath = @"C:\Users\User\Downloads\kt\sims5\Sims\Sims\Data\user.txt"; 
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
            if (newuser.Id[0] == 'd')
            {
                string filePath2 = @"C:\Users\User\Downloads\kt\sims5\Sims\Sims\Data\doctor.txt";
                List<string> lines2 = File.ReadAllLines(filePath2).ToList();
                foreach (var line2 in lines2)
                {
                    string[] entries2 = line2.Split(',');
                    if (newuser.Id == entries2[0])
                    {
                        var newDoctor = new Doctor { user = newuser };
                        newDoctor.SpecializationType = entries2[1];
                        doctors.Add(newDoctor);
                    }
                }
            }
        }
        appointments = new List<Appointment>();
        string filePath1 = @"C:\Users\User\Downloads\kt\sims5\Sims\Sims\Data\appointment.txt";
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

            foreach (var doc in doctors)
            {
                if (doc.user.Id == docId)
                {
                    newApp.doctor = doc;
                }
            }

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
  
    public void ReadAppointments()
    {
        appointments = new List<Appointment>();
        string filePath1 = @"C:\Users\User\Downloads\kt\sims5\Sims\Sims\Data\appointment.txt";
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

            foreach (var doc in doctors)
            {
                if (doc.user.Id == docId)
                {
                    newApp.doctor = doc;
                }
            }

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
   public List<Appointment> GetAppointmentsByDOC(string id)
    {
        List<Appointment> appointmentsByDoc = new List<Appointment>();
        foreach (var app in appointments)
        {
            if (app.doctor.user.Id == id)
            {
                appointmentsByDoc.Add(app);
            }
        }
        return appointmentsByDoc;
    }
    public List<Appointment> GetAppointments() {
        return appointments;
    }

    public List<Doctor> getDoctors()
    {
        return doctors;
    }
    public void createApp(string newId, string newStart, string newDuration, string newFinish)
    {
       /* Appointment newapp = new Appointment();
        newapp.Id = newId;
        newapp.Start = newStart;
        newapp.Finish = newFinish;
        newapp.Duration = newDuration;
        appointments.Add(newapp);*/
        string filePath1 = @"C:\Users\User\Downloads\kt\sims5\Sims\Sims\Data\appointment.txt";
        List<string> lines = new List<string>();
        lines = File.ReadAllLines(filePath1).ToList();
        string id = newId;//"A1";
        string start =newStart;//"12";
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
    public void write()
    {
        string filePath1 = @"C:\Users\User\Downloads\kt\sims5\Sims\Sims\Data\appointment.txt";
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
    public string FileLocation { get; set; }
    public List<Doctor> doctors;
    public List<Appointment> appointments;
    public List<Patient> patients;
    //------------------------------------------------------------OPERATIONS BELLOW----------------------------------------------------------------
    public void ReadOperations()
    {
        string filePath = @"C:\Users\User\Downloads\kt\sims5\Sims\Sims\Data\operations.txt";
        List<string> lines = File.ReadAllLines(filePath).ToList();

        foreach (var line in lines)
        {
            var newOperation = new Operations();

            string[] entries = line.Split(',');
            newOperation.Id = entries[0];
            newOperation.Start = Convert.ToDouble(entries[1]);
            newOperation.Duration = Convert.ToDouble(entries[2]);
            newOperation.PatientId = entries[3];
            newOperation.DoctorId = entries[4];
            newOperation.RoomId = Convert.ToInt32(entries[5]);

            operations.Add(newOperation);
        }
    }
    public void WriteOperations()
    {
        string filePath1 = @"C:\Users\User\Downloads\kt\sims5\Sims\Sims\Data\operations.txt";
        List<string> lines = new List<string>();
        foreach (var op in operations)
        {
            string id = op.Id;
            string start = op.Start.ToString();
            string duration = op.Duration.ToString();
            string patientid = op.PatientId;
            string doctorid = op.DoctorId;
            string roomId = op.RoomId.ToString();
            string s10 = id + "," + start + "," + duration + "," + patientid + "," + doctorid + "," + roomId;
            lines.Add(s10);
        }
        File.WriteAllLines(filePath1, lines);
    }
    public void CreateOperation(string newId, double newStart, double newDuration, string newPatientId, string newDoctorId, int roomId)
    {
        Operations o = new Operations();
        o.DoctorId = newDoctorId;
        o.Duration = newDuration;
        o.Id = newId;
        o.Start = newStart;
        o.PatientId = newPatientId;
        o.RoomId = roomId;

        operations.Add(o);
    }
    public void UpdateOperation(string newId, double newStart, double newDuration, string newPatientId, string newDoctorId, int roomId)
    {
        foreach(var op in operations)
        {
            if (newId == op.Id)
            {
                op.DoctorId = newDoctorId;
                op.Duration = newDuration;
                op.Id = newId;
                op.Start = newStart;
                op.PatientId = newPatientId;
                op.RoomId = roomId;
            }
        }
    }
    public void DeleteOperation(string newId)
    {
        List<Operations> newList = new List<Operations>();
        foreach (var op in operations)
        {
            if (op.Id != newId)
            {
                newList.Add(op);
            }
        }
        operations = newList;
    }
    public List<Operations> GetOperationsByDOC(string id)
    {
        List<Operations> operationsByDoc = new List<Operations>();
        foreach(var op in operations)
        {
            if (op.DoctorId == id)
            {
                operationsByDoc.Add(op);
            }
        }
        return operationsByDoc;
    }
        public List<Operations> GetOperations()
    {
        return operations;
    }
    public List<Operations> operations;
    //------------------------------------------------------CREATING RECEIPE AND MEDICINES------------------------------------------------------
    public List<Medicine> medicines;
    public List<Receipt> receipts;
    public void ReadMedicines()
    {
        string filePath = @"C:\Users\User\Downloads\kt\sims5\Sims\Sims\Data\medicine.txt";
        List<string> lines = File.ReadAllLines(filePath).ToList();

        foreach (var line in lines)
        {
            var newMedicine = new Medicine();

            string[] entries = line.Split(',');
            newMedicine.Id = entries[0];
            newMedicine.Name = entries[1];
            newMedicine.Description = entries[2];

            medicines.Add(newMedicine);
        }
    }
      public void ReadReceipts()
      {
          string filePath = @"C:\Users\User\Downloads\kt\sims5\Sims\Sims\Data\receipe.txt";
          List<string> lines = File.ReadAllLines(filePath).ToList();

          foreach (var line in lines)
          {
              var newOperation = new Operations();
              var newReceipt = new Receipt();
              bool r = false;
              string[] entries = line.Split(',');
              foreach(var rec in receipts)
              {
                if (rec.Id == entries[0])
                {
                    foreach (var med in medicines)
                    {
                        if (med.Id == entries[3])
                        {
                            rec.AddMedicine(med);
                            break;
                        }
                    }
                    r = true;
                    break;
                } 
              }
             if (r == false)
             {
                newReceipt.Id = entries[0];
                newReceipt.Description = entries[1];
                newReceipt.Quantity = Convert.ToInt32(entries[2]);
                foreach (var med in medicines)
                {
                    if (med.Id == entries[3])
                    {
                        newReceipt.AddMedicine(med);
                        break;
                    }

                }
                newReceipt.PatientId = entries[4];
                receipts.Add(newReceipt);
             }
             
          }
      }
     public void CreateReceipe(string newId, string newDescription, string newQuantity, string newMedicineId, string newPatientId )
    {
        string filePath1 = @"C:\Users\User\Downloads\kt\sims5\Sims\Sims\Data\receipe.txt";
        List<string> lines = new List<string>();
        lines = File.ReadAllLines(filePath1).ToList();
        string id = newId;//"A1";
        string description = newDescription;//"12";
        string quantity = newQuantity;//"1";
        string medicineId = newMedicineId;//"13";
        string patientId = newPatientId;
        string s10 = id + "," + description + "," + quantity + "," + medicineId + "," + patientId;
        lines.Add(s10);
        File.WriteAllLines(filePath1, lines);
    }
    public List<Receipt> GetReceipts()
    {
        return receipts;
    }
    public List<Medicine> GetMedicines()
    {
        return medicines;
    }
}

