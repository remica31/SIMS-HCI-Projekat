/***********************************************************************
 * Module:  Patient.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Patient
 ***********************************************************************/

using Model;
using Repository;
using System; using System.Collections.Generic;

namespace Service
{
   public class PatientService
   {
        public PatientRepository patientRepository = new PatientRepository();
        public AppointmentRepository appointmentRepository = new AppointmentRepository();
        public List<Patient> GetAll()
        {
            return patientRepository.GetAll();
        }

        public Patient GetById(String id)
        {
            return patientRepository.GetById(id);
        }

        public void Save(Patient patient)
        {
            patientRepository.Save(patient);
        }

        public void Delete(String id)
        {
            patientRepository.Delete(id);
        }
        /*
      public List<Patient> GetAll()
      {
         // TODO: implement
         return null;
      }
      
      public PatientService GetById(String id)
      {
         // TODO: implement
         return null;
      }
      
      public void Create(String newJmbg, String newUsername, String newPassword, String newID, String newName, String newSurname, String newEMail, String newAddress, String newPhone)
      {
         // TODO: implement
      }
      
      public void Update(String newEmail, String newAddress, String newPhone)
      {
         // TODO: implement
      }
      
      public void Delete(String id)
      {
         // TODO: implement
      }
   
      
   */
    }
}