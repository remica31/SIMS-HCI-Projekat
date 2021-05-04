/***********************************************************************
 * Module:  HospitalReferral.cs
 * Author:  Remica
 * Purpose: Definition of the Class Model.HospitalReferral
 ***********************************************************************/

using Model;
using Service;
using System; using System.Collections.Generic;

namespace Controller
{
   public class HospitalReferralController
   {
        private HospitalReferralService hospitalReferralService = new HospitalReferralService();

        public HospitalReferral GetById(string id)
        {
            return hospitalReferralService.GetById(id);
        }

        public void Save(HospitalReferral hospitalReferral)
        {
            hospitalReferralService.Save(hospitalReferral);
        }

        public void Delete(string id)
        {
            hospitalReferralService.Delete(id);
        }

        public void Update(HospitalReferral hospitalReferral)
        {
            hospitalReferralService.Update(hospitalReferral);
        }
        public List<HospitalReferral> GetAll()
        {
            return hospitalReferralService.GetAll();
        }
        /*
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
   
     
   */
    }
}