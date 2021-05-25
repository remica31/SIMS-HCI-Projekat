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
    public class AvailableAppointmentRepository
    {

        private readonly string fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\RefaktorisaniSims\\Data\\availableAppointments.json";//D:\Ovde radi sims\RefaktorisaniSims\RefaktorisaniSims\Data\appointments.json
        public List<AvailableAppointment> appointments = new List<AvailableAppointment>();

        public AvailableAppointmentRepository()
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
                    appointments = JsonConvert.DeserializeObject<List<AvailableAppointment>>(json);
                }
            }
        }

        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(appointments);
            File.WriteAllText(fileLocation, json);
        }
        public void Save(AvailableAppointment appointment)
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

        public void Update(AvailableAppointment appointment)
        {
            ReadJson();
            int index = appointments.FindIndex(obj => obj.Id == appointment.Id);
            appointments[index] = appointment;
            WriteToJson();
        }
        public AvailableAppointment GetById(String id)
        {
            // TODO: implement
            ReadJson();
            return appointments.Find(obj => obj.Id == id);
        }
        public List<AvailableAppointment> GetAll()
        {
            ReadJson();
            return appointments;
        }
        public List<AvailableAppointment> GetByDoctorId(string id)
        {

            List<AvailableAppointment> apps = new List<AvailableAppointment>();
            foreach (var app in appointments)
            {
                if (app.doctor.User.Id == id)
                {
                    apps.Add(app);
                }

            }
            return apps;

        }
    }
}