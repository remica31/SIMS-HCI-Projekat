/***********************************************************************
 * Module:  Appointment.cs
 * Author:  User
 * Purpose: Definition of the Class Appointment
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;

namespace Model
{
   public class Appointment
   {
      public void Create(String newId, double newStart, double newDuration, AppointmentType newType, double newFinish)
      {
         // TODO: implement
      }
      
      public void Update(double newStart, double newDuration, double newFinish)
      {
         // TODO: implement
      }
      
      public void Delete(String id)
      {
         // TODO: implement
      }
      
      public Appointment GetById(String id)
      {
         // TODO: implement
         return null;
      }
      
      public List<Appointment> GetByDoctorId(String doctorId)
      {
         // TODO: implement
         return null;
      }
      
      public List<Appointment> GetByPatientId(String patientId)
      {
         // TODO: implement
         return null;
      }
      
      public List<Appointment> GetAll()
      {
         // TODO: implement
         return null;
      }
   
      public String Id;
      public double Start;
      public double Duration;
      public AppointmentType Type;
      public double Finish;
      
      public Doctor doctor;
      public Patient patient;
      public System.Collections.ArrayList receipt;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetReceipt()
      {
         if (receipt == null)
            receipt = new System.Collections.ArrayList();
         return receipt;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetReceipt(System.Collections.ArrayList newReceipt)
      {
         RemoveAllReceipt();
         foreach (Receipt oReceipt in newReceipt)
            AddReceipt(oReceipt);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddReceipt(Receipt newReceipt)
      {
         if (newReceipt == null)
            return;
         if (this.receipt == null)
            this.receipt = new System.Collections.ArrayList();
         if (!this.receipt.Contains(newReceipt))
            this.receipt.Add(newReceipt);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveReceipt(Receipt oldReceipt)
      {
         if (oldReceipt == null)
            return;
         if (this.receipt != null)
            if (this.receipt.Contains(oldReceipt))
               this.receipt.Remove(oldReceipt);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllReceipt()
      {
         if (receipt != null)
            receipt.Clear();
      }
   
   }
}