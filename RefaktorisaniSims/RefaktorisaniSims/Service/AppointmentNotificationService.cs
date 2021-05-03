// File:    NotificationRefferal.cs
// Author:  LENOVO
// Created: Friday, April 9, 2021 21:35:22
// Purpose: Definition of Class NotificationRefferal

using Model;
using Repository;
using System; using System.Collections.Generic;

namespace Service
{
   public class AppointmentNotificationService
   {
        public AppointmentNotificationRepository appointmentNotificationRepository = new AppointmentNotificationRepository();


        public List<AppointmentNotification> GetAll()
        {
            return appointmentNotificationRepository.GetAll();
        }
        public void Save(AppointmentNotification appointmentNotification)
        {
            appointmentNotificationRepository.Save(appointmentNotification);


        }
        /*
      public void SendTo(String patientId, String doctorId)
      {
         // TODO: implement
      }
   
      
   */
    }
}