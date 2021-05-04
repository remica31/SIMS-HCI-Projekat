/***********************************************************************
 * Module:  Doctor.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Doctor
 ***********************************************************************/

using Model;
using Service;
using System; using System.Collections.Generic;

namespace Controller
{
   public class DoctorController
   {
        private DoctorService doctorService = new DoctorService();

        public List<Doctor> GetAll()
        {
            return doctorService.GetAll();
        }

        public Doctor GetById(String id)
        {
            return doctorService.GetById(id);
        }

        public void Save(Doctor doctor)
        {
            doctorService.Save(doctor);
        }

        public void Delete(String jmbg)
        {
            doctorService.Delete(jmbg);
        }
        public List<Doctor> GetBySpeacialization(string specialization)
        {
            return doctorService.GetBySpeacialization(specialization);
        }

    }
}