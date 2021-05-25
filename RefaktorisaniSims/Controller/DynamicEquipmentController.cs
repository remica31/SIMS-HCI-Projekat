/***********************************************************************
 * Module:  DynamicEquipmentController.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Controller.DynamicEquipmentController
 ***********************************************************************/

using Model;
using Service;
using System; using System.Collections.Generic;

namespace Controller
{
   public class DynamicEquipmentController
   {
        public DynamicEquipmentService DynamicEquipmentService = new DynamicEquipmentService();

        public void Save(DynamicEquipment dyneq)
        {
            DynamicEquipmentService.Save(dyneq);
        }

        public void Update(DynamicEquipment dyneq)
        {
            DynamicEquipmentService.Update(dyneq);
        }

        public void Delete(string id)
        {
            DynamicEquipmentService.Delete(id);
        }

        public DynamicEquipment GetById(string id)
        {
            return DynamicEquipmentService.GetById(id);
        }

        public List<DynamicEquipment> GetAll()
        {
            return DynamicEquipmentService.GetAll();
        }

        public DynamicEquipment GetByName(string name)
        {
            return DynamicEquipmentService.GetByName(name);
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