/***********************************************************************
 * Module:  StaticTransferSchedule.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.StaticTransferSchedule
 ***********************************************************************/

using Model;
using Repository;
using System; using System.Collections.Generic;
using System.Windows;

namespace Service
{
   public class StaticTransferScheduleService
   {
        public StaticTransferScheduleRepository StaticTransferScheduleRepository = new StaticTransferScheduleRepository();

        public void Save(StaticTransferSchedule staticeq)
        {
            List<StaticTransferSchedule> requests = StaticTransferScheduleRepository.GetAll();
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
                StaticTransferScheduleRepository.Save(staticeq);
            }
        }

        public void Delete(string id)
        {
            StaticTransferScheduleRepository.Delete(id);
        }

        public StaticTransferSchedule GetById(string id)
        {
            return StaticTransferScheduleRepository.GetById(id);
        }

        public void Update(StaticTransferSchedule staticeq)
        {
            StaticTransferScheduleRepository.Update(staticeq);
        }

        public List<StaticTransferSchedule> GetAll()
        {
            return StaticTransferScheduleRepository.GetAll();
        }

        /*
      public void Create(String newid, DateTime newDate)
      {
         // TODO: implement
      }
      
      public List<StaticTransferSchedule> ReadAll()
      {
         // TODO: implement
         return null;
      }
      
      public StaticTransferSchedule ReadById(String id)
      {
         // TODO: implement
         return null;
      }
   */


    }
}