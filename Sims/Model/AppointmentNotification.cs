// File:    NotificationRefferal.cs
// Author:  LENOVO
// Created: Friday, April 9, 2021 21:35:22
// Purpose: Definition of Class NotificationRefferal

using System;

namespace Model
{
   public class AppointmentNotification
   {
      public void SendTo(Patient patient, Doctor doctor)
      {
         // TODO: implement
      }
   
      public int id;
      public DateTime date;
      public DateTime startTime;
      public DateTime endTime;
      public string description;
   
   }
}