/***********************************************************************
 * Module:  StaticEquipments.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.StaticEquipments
 ***********************************************************************/

using Model;
using Service;
using System; using System.Collections.Generic;


namespace Controller
{
   public class StaticEquipmentController
   {
        public StaticEquipmentService StaticEquipmentService = new StaticEquipmentService();

        public void Save(StaticEquipment staticeq)
        {
            StaticEquipmentService.Save(staticeq);
        }

        public void Update(StaticEquipment staticeq)
        {
            StaticEquipmentService.Update(staticeq);
        }

        public void Delete(string id)
        {
            StaticEquipmentService.Delete(id);
        }

        public StaticEquipment GetById(string id)
        {
            return StaticEquipmentService.GetById(id);
        }

        public List<StaticEquipment> GetAll()
        {
            return StaticEquipmentService.GetAll();
        }
        /*
      public void Delete(String id)
      {
         // TODO: implement
      }
      
      public void Update(String id, String name, String warehouseId, int quantity)
      {
         // TODO: implement
      }
      
      public void Create(String newFromRoomId, DateTime newDate, String newToRoomId)
      {
         // TODO: implement
      }
      
      public List<StaticTransferSchedule> ReadAll()
      {
         // TODO: implement
         return null;
      }
      
      public Model.StaticTransferSchedule ReadById(String id)
      {
         // TODO: implement
         return null;
      }
      
      public List<StaticEquipment> SearchByName(String name)
      {
         // TODO: implement
         return null;
      }*/



    }
}