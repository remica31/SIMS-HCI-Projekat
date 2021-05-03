using Model;
using Service;
using System; using System.Collections.Generic;


namespace Controller
{
    public class AvailableAppointmentController
    {
        private AvailableAppointmentService appointmentService = new AvailableAppointmentService();

        public List<AvailableAppointment> GetAll()
        {
            return appointmentService.GetAll();
        }

        public AvailableAppointment GetById(string id)
        {
            return appointmentService.GetById(id);
        }

        public void Save(AvailableAppointment appointment)
        {
            appointmentService.Save(appointment);
        }

        public void Delete(string id)
        {
            appointmentService.Delete(id);
        }

        public void Update(AvailableAppointment appointment)
        {
            appointmentService.Update(appointment);
        }
        public List<AvailableAppointment> GetByDoctorId(string id)
        {

            return appointmentService.GetByDoctorId(id);
        }
    }
}