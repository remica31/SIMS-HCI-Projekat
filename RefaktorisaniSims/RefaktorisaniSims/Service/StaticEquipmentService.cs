/***********************************************************************
 * Module:  StaticEquipments.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.StaticEquipments
 ***********************************************************************/

using Model;
using Repository;
using System; using System.Collections.Generic;
using System.Windows;

namespace Service
{
   public class StaticEquipmentService
   {
        public StaticEquipmentRepository StaticEquipmentRepository = new StaticEquipmentRepository();

        public void Save(StaticEquipment staticeq)
        {
            List<StaticEquipment> requests = StaticEquipmentRepository.GetAll();
            bool idExists = false;
            foreach (var req in requests)
            {
                if (staticeq.Id == req.Id)
                {
                    MessageBox.Show("Id already exists!");
                    idExists = true;

                }
            }
            if (!idExists)
            {
                StaticEquipmentRepository.Save(staticeq);
            }
        }

        public void Delete(string id)
        {
            StaticEquipmentRepository.Delete(id);
        }

        public StaticEquipment GetById(string id)
        {
            return StaticEquipmentRepository.GetById(id);
        }

        public void Update(StaticEquipment staticeq)
        {
            StaticEquipmentRepository.Update(staticeq);
        }

        public List<StaticEquipment> GetAll()
        {
            return StaticEquipmentRepository.GetAll();
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
      
      public Model.StaticEquipment ReadById(String id)
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