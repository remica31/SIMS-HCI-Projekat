// File:    NotificationRefferal.cs
// Author:  LENOVO
// Created: Friday, April 9, 2021 21:35:22
// Purpose: Definition of Class NotificationRefferal

using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class AppointmentNotification
   {
      public void SendTo(String patientId, String doctorId)
      {
         // TODO: implement
      }
        public AppointmentNotification(int Id, DateTime date, string desc, string patientId, string doctorId)
        {
            this.Id = Id;
            Date = date;
            Description = desc;
            PatientID = patientId;
            DoctorID = doctorId;

        }
        public AppointmentNotification() { }

      public int Id { get; set; }
      public DateTime Date { get; set; }
        public String Description { get; set; }

        public String PatientID { get; set; }
        public String DoctorID { get; set; }

        public Appointment appointment;
   
   }
}