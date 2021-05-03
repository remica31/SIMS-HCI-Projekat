/***********************************************************************
 * Module:  HospitalReferral.cs
 * Author:  Remica
 * Purpose: Definition of the Class Model.HospitalReferral
 ***********************************************************************/

using Model;
using Repository;
using System; using System.Collections.Generic;

namespace Service
{
   public class HospitalReferralService
   {
        public HospitalReferralRepository hospitalReferralRepository = new HospitalReferralRepository();


        public HospitalReferral GetById(string id)
        {
            return hospitalReferralRepository.GetById(id);
        }

        public void Save(HospitalReferral hospitalReferral)
        {
            hospitalReferralRepository.Save(hospitalReferral);


        }

        public void Delete(string id)
        {
            hospitalReferralRepository.Delete(id);
        }

        public void Update(HospitalReferral hospitalReferral)
        {
            hospitalReferralRepository.Update(hospitalReferral);

        }
        public List<HospitalReferral> GetAll()
        {
            return hospitalReferralRepository.GetAll();
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