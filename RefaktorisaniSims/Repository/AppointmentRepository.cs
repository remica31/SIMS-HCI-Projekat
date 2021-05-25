/***********************************************************************
 * Module:  Appointment.cs
 * Author:  User
 * Purpose: Definition of the Class Appointment
 ***********************************************************************/

using Model;
using Newtonsoft.Json;
using System; using System.Collections.Generic;
using System.IO;

namespace Repository
{
   public class AppointmentRepository
   {

        private readonly string fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\RefaktorisaniSims\\Data\\appointments.json";//D:\Ovde radi sims\RefaktorisaniSims\RefaktorisaniSims\Data\appointments.json
        public List<Appointment> appointments = new List<Appointment>();

        public AppointmentRepository()
        {
            ReadJson();
        }

        public void ReadJson()
        {
            if (!File.Exists(fileLocation))
            {
                File.Create(fileLocation).Close();
            }

            using (StreamReader r = new StreamReader(fileLocation))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    appointments = JsonConvert.DeserializeObject<List<Appointment>>(json);
                }
            }
        }

        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(appointments);
            File.WriteAllText(fileLocation, json);
        }
        public void Save(Appointment appointment)
        {
            ReadJson();
            appointments.Add(appointment);
            WriteToJson();
        }

        public void Delete(string id)
        {
            ReadJson();

            int index = appointments.FindIndex(obj => obj.Id == id);
            appointments.RemoveAt(index);
            WriteToJson();
        }

        public void Update(Appointment appointment)
        {
            ReadJson();
            int index = appointments.FindIndex(obj => obj.Id == appointment.Id);
            appointments[index] = appointment;
            WriteToJson();
        }
        public Appointment GetById(String id)
        {
            // TODO: implement
            ReadJson();
            return appointments.Find(obj => obj.Id == id);
        }
        public List<Appointment> GetAll()
        {
            ReadJson();
            return appointments;
        }
        public List<Appointment> GetByDoctorId(string id)
        {
            
            List<Appointment> apps=new List<Appointment>();
            foreach(var app in appointments)
            {
                if (app.doctor.User.Id == id)
                {
                    apps.Add(app);
                }
              
            }
            return apps;

        }
        /*    public void Create(String newId, DateTime newStartTime, int newDuration, Model.AppointmentType newType, DateTime newFinishTime)
          {
             // TODO: implement
          }

          public void Update(DateTime newStartTime, int newDuration)
          {
             // TODO: implement
          }

          public void Delete(String id)
          {
             // TODO: implement
          }

          public List<Appointment> GetByPatientId(String patientId)
          {
             // TODO: implement
             return null;
          }

         

          public Model.StatusType UpdateStatus(Model.StatusType newStatus)
          {
             // TODO: implement
             return null;
          }

          public void CreateAppointmentByReferral(String id, DateTime startTime, int duration, Model.AppointmentType type, DateTime finishTime, Model.HospitalReferral referral)
          {
             // TODO: implement
          }
                */
    }
}