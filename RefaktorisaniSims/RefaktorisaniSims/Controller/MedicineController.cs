/***********************************************************************
 * Module:  Medicine.cs
 * Author:  Remica
 * Purpose: Definition of the Class Model.Medicine
 ***********************************************************************/

using Model;
using Service;
using System; using System.Collections.Generic;

namespace Controller
{
   public class MedicineController
   {
        private MedicineService medicineService = new MedicineService();

        public List<Medicine> GetAll()
        {
            return medicineService.GetAll();
        }

        public Medicine GetById(string id)
        {
            return medicineService.GetById(id);
        }

        public void Save(Medicine medicine)
        {
            medicineService.Save(medicine);
        }

        public void Delete(string id)
        {
            medicineService.Delete(id);
        }

        public void Update(Medicine medicine)
        {
            medicineService.Update(medicine);
        }
        public List<Medicine> GetAllByStatus(string status)
        {
            return medicineService.GetAllByStatus(status);
        }
        /*
      public Model.Medicine ReadById(String id)
      {
         // TODO: implement
         return null;
      }
      
      public List<Medicine> ReadAll()
      {
         // TODO: implement
         return null;
      }
      
      public List<Medicine> GetAllByStatus(Model.StatusType status)
      {
         // TODO: implement
         return null;
      }
      
      public void Update(String id, String description, Model.StatusType status, String doctorComment, String ingredients)
      {
         // TODO: implement
      }
      
      public void Create(String id, String name, String description, Model.StatusType status, String ingredients)
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