/***********************************************************************
 * Module:  MedicineNotificationController.cs
 * Author:  Remica
 * Purpose: Definition of the Class Controller.MedicineNotificationController
 ***********************************************************************/

using Model;
using Service;
using System; using System.Collections.Generic;

namespace Controller
{
        public class MedicineNotificationController
        {
            private MedicineNotificationService medicineNotificationService = new MedicineNotificationService();

            public List<MedicineNotification> GetAll()
            {
                return medicineNotificationService.GetAll();
            }

            public MedicineNotification GetById(string id)
            {
                return medicineNotificationService.GetById(id);
            }

            public void Save(MedicineNotification medicineNotification)
            {
                medicineNotificationService.Save(medicineNotification);
            }

            public void Delete(string id)
            {
                medicineNotificationService.Delete(id);
            }

            public void Update(MedicineNotification medicineNotification)
            {
                medicineNotificationService.Update(medicineNotification);
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