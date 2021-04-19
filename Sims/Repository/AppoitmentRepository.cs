/***********************************************************************
 * Module:  Appointment.cs
 * Author:  User
 * Purpose: Definition of the Class Appointment
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;

namespace Repository
{
   public class AppointmentRepository
   {
      public void Create(String newId, double newStart, double newDuration, Model.AppointmentType newType, double newFinish)
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
   
   }
}