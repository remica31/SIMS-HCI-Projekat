/***********************************************************************
 * Module:  Appointment.cs
 * Author:  User
 * Purpose: Definition of the Class Appointment
 ***********************************************************************/


using Model;
using Repository;
using System; using System.Collections.Generic;


namespace Service
{
   public class AppointmentService
   {
        public AppointmentRepository appointmentRepository = new AppointmentRepository();


        public List<Appointment> GetAll()
        {
            return appointmentRepository.GetAll();
        }

        public Appointment GetById(string id)
        {
            return appointmentRepository.GetById(id);
        }

        public void Save(Appointment appointment)
        {
            appointmentRepository.Save(appointment);
           
            
        }

        public void Delete(string id)
        {
            appointmentRepository.Delete(id);
        }

        public void Update(Appointment appointment)
        {
            appointmentRepository.Update(appointment);
           
        }
        public List<Appointment> GetByDoctorId(string id)
        {
            
            return appointmentRepository.GetByDoctorId(id);
        }
        public List<Appointment> AppointmentsToCancel(string specialization)
        {
            List<Appointment> appointments = new List<Appointment>();
            appointments = appointmentRepository.GetAll();
            List<Appointment> appsToCancel = new List<Appointment>();
            foreach (var app in appointments)
            {
                if (app.doctor.SpecializationType == specialization)
                {
                    appsToCancel.Add(app);
                }
            }
            return appsToCancel;
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

          public AppointmentRepository appointmentRepository;
       */
    }
}