// File:    NotificationRefferal.cs
// Author:  LENOVO
// Created: Friday, April 9, 2021 21:35:22
// Purpose: Definition of Class NotificationRefferal

using Model;
using Newtonsoft.Json;
using System; using System.Collections.Generic;
using System.IO;

namespace Repository
{
   public class AppointmentNotificationRepository
   {
        private readonly string fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\RefaktorisaniSims\\Data\\appointmentNotifications.json";//D:\Ovde radi sims\RefaktorisaniSims\RefaktorisaniSims\Data\appointmentNotifications.json
        public List<AppointmentNotification> appointmentNotifications = new List<AppointmentNotification>();

        public AppointmentNotificationRepository()
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
                    appointmentNotifications = JsonConvert.DeserializeObject<List<AppointmentNotification>>(json);
                }
            }
        }

        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(appointmentNotifications);
            File.WriteAllText(fileLocation, json);
        }
        public void Save(AppointmentNotification appointmentNotification)
        {
            ReadJson();
            appointmentNotifications.Add(appointmentNotification);
            WriteToJson();
        }
        public List<AppointmentNotification> GetAll()
        {
            ReadJson();
            return appointmentNotifications;
        }
        /*
      public void SendTo(String patientId, String doctorId)
      {
         // TODO: implement
      }
   */
    }
}