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
    public class AvailableAppointmentService
    {
        public AvailableAppointmentRepository appointmentRepository = new AvailableAppointmentRepository();


        public List<AvailableAppointment> GetAll()
        {
            return appointmentRepository.GetAll();
        }

        public AvailableAppointment GetById(string id)
        {
            return appointmentRepository.GetById(id);
        }

        public void Save(AvailableAppointment appointment)
        {
            appointmentRepository.Save(appointment);


        }

        public void Delete(string id)
        {
            appointmentRepository.Delete(id);
        }

        public void Update(AvailableAppointment appointment)
        {
            appointmentRepository.Update(appointment);

        }
        public List<AvailableAppointment> GetByDoctorId(string id)
        {

            return appointmentRepository.GetByDoctorId(id);
        }
    }
}