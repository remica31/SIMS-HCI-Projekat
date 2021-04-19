/***********************************************************************
 * Module:  Secretary.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Secretary
 ***********************************************************************/

using System;

namespace Model
{
   public class Secretary
   {
      public User user;
      public System.Collections.ArrayList medicalRecord;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetMedicalRecord()
      {
         if (medicalRecord == null)
            medicalRecord = new System.Collections.ArrayList();
         return medicalRecord;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetMedicalRecord(System.Collections.ArrayList newMedicalRecord)
      {
         RemoveAllMedicalRecord();
         foreach (MedicalRecord oMedicalRecord in newMedicalRecord)
            AddMedicalRecord(oMedicalRecord);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddMedicalRecord(MedicalRecord newMedicalRecord)
      {
         if (newMedicalRecord == null)
            return;
         if (this.medicalRecord == null)
            this.medicalRecord = new System.Collections.ArrayList();
         if (!this.medicalRecord.Contains(newMedicalRecord))
            this.medicalRecord.Add(newMedicalRecord);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveMedicalRecord(MedicalRecord oldMedicalRecord)
      {
         if (oldMedicalRecord == null)
            return;
         if (this.medicalRecord != null)
            if (this.medicalRecord.Contains(oldMedicalRecord))
               this.medicalRecord.Remove(oldMedicalRecord);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllMedicalRecord()
      {
         if (medicalRecord != null)
            medicalRecord.Clear();
      }
      public System.Collections.ArrayList appointmentNotification;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetAppointmentNotification()
      {
         if (appointmentNotification == null)
            appointmentNotification = new System.Collections.ArrayList();
         return appointmentNotification;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetAppointmentNotification(System.Collections.ArrayList newAppointmentNotification)
      {
         RemoveAllAppointmentNotification();
         foreach (AppointmentNotification oAppointmentNotification in newAppointmentNotification)
            AddAppointmentNotification(oAppointmentNotification);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddAppointmentNotification(AppointmentNotification newAppointmentNotification)
      {
         if (newAppointmentNotification == null)
            return;
         if (this.appointmentNotification == null)
            this.appointmentNotification = new System.Collections.ArrayList();
         if (!this.appointmentNotification.Contains(newAppointmentNotification))
            this.appointmentNotification.Add(newAppointmentNotification);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveAppointmentNotification(AppointmentNotification oldAppointmentNotification)
      {
         if (oldAppointmentNotification == null)
            return;
         if (this.appointmentNotification != null)
            if (this.appointmentNotification.Contains(oldAppointmentNotification))
               this.appointmentNotification.Remove(oldAppointmentNotification);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllAppointmentNotification()
      {
         if (appointmentNotification != null)
            appointmentNotification.Clear();
      }
   
   }
}