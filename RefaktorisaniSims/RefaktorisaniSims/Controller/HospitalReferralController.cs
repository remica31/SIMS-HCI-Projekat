/***********************************************************************
 * Module:  HospitalReferral.cs
 * Author:  Remica
 * Purpose: Definition of the Class Model.HospitalReferral
 ***********************************************************************/

using Model; using System; using System.Collections.Generic;

namespace Controller
{
   public class HospitalReferralController
   {
      public void Create(String id, String patientId, String toDoctorId, String fromDoctorId, String explanation)
      {
         // TODO: implement
      }
      
      public void Update(String id, String toDoctorId, String fromDoctorId, String explanation)
      {
         // TODO: implement
      }
      
      public List<HospitalReferral> GetByPatientId(String patientId)
      {
         // TODO: implement
         return null;
      }
      
      public List<HospitalReferral> GetByToDoctorId(String toDoctorId)
      {
         // TODO: implement
         return null;
      }
      
      public void DeleteById(String id)
      {
         // TODO: implement
      }
   
     
   
   }
}