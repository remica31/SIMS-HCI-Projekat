/***********************************************************************
 * Module:  Medicine.cs
 * Author:  Remica
 * Purpose: Definition of the Class Model.Medicine
 ***********************************************************************/

using Model;
using Repository;
using System; using System.Collections.Generic;

namespace Service
{
   public class MedicineService
   {
        public MedicineRepository medicineRepository = new MedicineRepository();


        public List<Medicine> GetAll()
        {
            return medicineRepository.GetAll();
        }

        public Medicine GetById(string id)
        {
            return medicineRepository.GetById(id);
        }

        public void Save(Medicine medicine)
        {
            medicineRepository.Save(medicine);


        }

        public void Delete(string id)
        {
            medicineRepository.Delete(id);
        }

        public void Update(Medicine medicine)
        {
            medicineRepository.Update(medicine);

        }
        public List<Medicine> GetAllByStatus(string status)
        {
            return medicineRepository.GetAllByStatus(status);
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