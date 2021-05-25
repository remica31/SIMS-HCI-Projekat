/***********************************************************************
 * Module:  Patient.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Patient
 ***********************************************************************/

using Model;
using Service;
using System; using System.Collections.Generic;

namespace Controller
{
   public class PatientController
   {
        private PatientService patientService = new PatientService();

        public List<Patient> GetAll()
        {
            return patientService.GetAll();
        }

        public Patient GetById(String id)
        {
            return patientService.GetById(id);
        }

        public void Save(Patient patient)
        {
            patientService.Save(patient);
        }

        public void Delete(String id)
        {
            patientService.Delete(id);
        }

        /*
      public List<Patient> GetAll()
      {
         // TODO: implement
         return null;
      }
      
      public PatientController GetById(String id)
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