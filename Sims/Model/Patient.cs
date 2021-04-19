/***********************************************************************
 * Module:  Patient.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Patient
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;

namespace Model
{
   public class Patient
   {
      public List<Patient> GetAll()
      {
         // TODO: implement
         return null;
      }
      
      public Patient GetById(String id)
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
   
      public User user;
      public System.Collections.ArrayList patientB;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetPatientB()
      {
         if (patientB == null)
            patientB = new System.Collections.ArrayList();
         return patientB;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetPatientB(System.Collections.ArrayList newPatientB)
      {
         RemoveAllPatientB();
         foreach (Patient oPatient in newPatientB)
            AddPatientB(oPatient);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddPatientB(Patient newPatient)
      {
         if (newPatient == null)
            return;
         if (this.patientB == null)
            this.patientB = new System.Collections.ArrayList();
         if (!this.patientB.Contains(newPatient))
            this.patientB.Add(newPatient);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemovePatientB(Patient oldPatient)
      {
         if (oldPatient == null)
            return;
         if (this.patientB != null)
            if (this.patientB.Contains(oldPatient))
               this.patientB.Remove(oldPatient);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllPatientB()
      {
         if (patientB != null)
            patientB.Clear();
      }
      public MedicalRecord medicalRecord;
      public Appointment[] appointment;
   
   }
}