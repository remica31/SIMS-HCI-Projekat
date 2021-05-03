/***********************************************************************
 * Module:  DynamicEquipmentController.cs
 * Author:  Remica
 * Purpose: Definition of the Class Controller.DynamicEquipmentController
 ***********************************************************************/

using Model;
using Repository;
using System; using System.Collections.Generic;
using System.Windows;

namespace Service
{
   public class DynamicEquipmentService
   {
        public DynamicEquipmentRepository DynamicEquipmentRepository = new DynamicEquipmentRepository();

        public void Save(DynamicEquipment dyneq)
        {
            List<DynamicEquipment> requests = DynamicEquipmentRepository.GetAll();
            bool idExists = false;
            foreach (var req in requests)
            {
                if (dyneq.Id == req.Id)
                {
                    MessageBox.Show("Id already exists!");
                    idExists = true;

                }
            }
            if (!idExists)
            {
                DynamicEquipmentRepository.Save(dyneq);
            }
        }

        public void Delete(string id)
        {
            DynamicEquipmentRepository.Delete(id);
        }

        public DynamicEquipment GetById(string id)
        {
            return DynamicEquipmentRepository.GetById(id);
        }

        public void Update(DynamicEquipment dyneq)
        {
            DynamicEquipmentRepository.Update(dyneq);
        }

        public List<DynamicEquipment> GetAll()
        {
            return DynamicEquipmentRepository.GetAll();
        }
        /*
      public List<DynamicEquipment> GetAll()
      {
         // TODO: implement
         return null;
      }
      
      public Model.DynamicEquipment GetById(String id)
      {
         // TODO: implement
         return null;
      }
      
      public void Delete(String id)
      {
         // TODO: implement
      }
      
      public void Update(String id, String name, String warehouse, int quantity)
      {
         // TODO: implement
      }
      
      public void Create(String id, String name, String warehouse, int quantity)
      {
         // TODO: implement
      }
      
      public List<DynamicEquipment> SearchByName(String name)
      {
         // TODO: implement
         return null;
      }*/



    }
}