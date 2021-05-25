/***********************************************************************
 * Module:  Appointment.cs
 * Author:  User
 * Purpose: Definition of the Class Appointment
 ***********************************************************************/

using Model;
using Service;
using System; using System.Collections.Generic;


namespace Controller
{
   public class AppointmentController
   {
        private AppointmentService appointmentService = new AppointmentService();

        public List<Appointment> GetAll()
        {
            return appointmentService.GetAll();
        }

        public Appointment GetById(string id)
        {
            return appointmentService.GetById(id);
        }

        public void Save(Appointment appointment)
        {
            appointmentService.Save(appointment);
        }

        public void Delete(string id)
        {
            appointmentService.Delete(id);
        }

        public void Update(Appointment appointment)
        {
            appointmentService.Update(appointment);
        }
        public List<Appointment> GetByDoctorId(string id)
        {
            
            return appointmentService.GetByDoctorId(id);
        }
        /*
      public void Create(String newId, DateTime newStartTime, int newDuration, Model.AppointmentType newType, DateTime newFinishTime)
      {
         // TODO: implement
      }
      
      public void Update(DateTime newStartTime, int newDuration)
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
      
      public Model.StatusType UpdateStatus(Model.StatusType newStatus)
      {
         // TODO: implement
         return null;
      }
      
      public void CreateAppointmentByReferral(String id, DateTime startTime, int duration, Model.AppointmentType type, DateTime finishTime, Model.HospitalReferral referral)
      {
         // TODO: implement
      }
   
      public AppointmentService appointmentService;
   */
    }
}