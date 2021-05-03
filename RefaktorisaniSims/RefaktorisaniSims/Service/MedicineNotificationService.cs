/***********************************************************************
 * Module:  MedicineNotificationController.cs
 * Author:  Remica
 * Purpose: Definition of the Class Controller.MedicineNotificationController
 ***********************************************************************/

using Model;
using Repository;
using System; using System.Collections.Generic;

namespace Service
{
   public class MedicineNotificationService
   {
        public MedicineNotificationRepository medicineNotificationRepository = new MedicineNotificationRepository();


        public List<MedicineNotification> GetAll()
        {
            return medicineNotificationRepository.GetAll();
        }

        public MedicineNotification GetById(string id)
        {
            return medicineNotificationRepository.GetById(id);
        }

        public void Save(MedicineNotification medicineNotification)
        {
            medicineNotificationRepository.Save(medicineNotification);


        }

        public void Delete(string id)
        {
            medicineNotificationRepository.Delete(id);
        }

        public void Update(MedicineNotification medicineNotification)
        {
            medicineNotificationRepository.Update(medicineNotification);

        }
        /*
      public void Create(String id, DateTime start, DateTime finish, int step, String description)
      {
         // TODO: implement
      }
      
      public int Update(DateTime newStart, DateTime newFinish, String newId, int newStep, String newDescription)
      {
         // TODO: implement
         return 0;
      }
      
      public int Delete()
      {
         // TODO: implement
         return 0;
      }
      
      public List<MedicineNotification> GetAll()
      {
         // TODO: implement
         return null;
      }
      
      public List<MedicineNotification> GetByPatientId(String patientId)
      {
         // TODO: implement
         return null;
      }
   
        */

    }
}