/***********************************************************************
 * Module:  Appointment.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Appointment
 ***********************************************************************/

using System.Collections.Generic;
using System; 


public class Appointment
{
   public void Create(int newId, DateTime newDate, TimeSpan newDuration, AppointmentType newType)
   {
      // TODO: implement
   }
   
   public void Update(DateTime newDate)
   {
      // TODO: implement
   }
   
   public void Delete(int id)
   {
      // TODO: implement
   }
   
   public Appointment GetById(int id)
   {
      // TODO: implement
      return null;
   }
   
   public List<Appointment> GetByDoctorId(int doctorId)
   {
      // TODO: implement
      return null;
   }
   
   public List<Appointment> GetByPatientId(int patientId)
   {
      // TODO: implement
      return null;
   }
   
   public List<Appointment> GetAll()
   {
      // TODO: implement
      return null;
   }

   public int Id;
   public DateTime Date;
   public TimeSpan Duration;
   public AppointmentType Type;
   
   public Doctor doctor;
   public Patient patient;

}