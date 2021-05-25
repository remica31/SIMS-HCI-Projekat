// File:    NotificationRefferal.cs
// Author:  LENOVO
// Created: Friday, April 9, 2021 21:35:22
// Purpose: Definition of Class NotificationRefferal

using Model;
using Service;
using System; using System.Collections.Generic;

namespace Controller
{
   public class AppointmentNotificationController
   {
        private AppointmentNotificationService appointmentNotificationService = new AppointmentNotificationService();

        public List<AppointmentNotification> GetAll()
        {
            return appointmentNotificationService.GetAll();
        }

        public void Save(AppointmentNotification appointmentNotification)
        {
            appointmentNotificationService.Save(appointmentNotification);
        }
        /*
      public void SendTo(String patientId, String doctorId)
      {
         // TODO: implement
      }
   */


    }
}