/***********************************************************************
 * Module:  Doctor.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Doctor
 ***********************************************************************/

using Model; using System; using System.Collections.Generic;

namespace Service
{
   public class DoctorService
   {
        private Repository.DoctorRepository doctorRepository = new Repository.DoctorRepository();
        public List<Doctor> GetAll()
        {
            return doctorRepository.GetAll();
        }

        public Doctor GetById(String id)
        {
            return doctorRepository.GetById(id);
        }

        public void Save(Doctor doctor)
        {
            doctorRepository.Save(doctor);
        }

        public void Delete(String doctor)
        {
            doctorRepository.Delete(doctor);
        }

        public List<Doctor> GetBySpeacialization(string specialization)
        {
            return doctorRepository.GetBySpeacialization(specialization);
        }



    }
}