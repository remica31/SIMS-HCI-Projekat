/***********************************************************************
 * Module:  StaticTransferSchedule.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.StaticTransferSchedule
 ***********************************************************************/

using Model;
using Service;
using System; using System.Collections.Generic;


namespace Controller
{
   public class StaticTransferScheduleController
   {
        public StaticTransferScheduleService StaticTransferScheduleService = new StaticTransferScheduleService();

        public void Save(StaticTransferSchedule staticeq)
        {
            StaticTransferScheduleService.Save(staticeq);
        }

        public void Update(StaticTransferSchedule staticeq)
        {
            StaticTransferScheduleService.Update(staticeq);
        }

        public void Delete(string id)
        {
            StaticTransferScheduleService.Delete(id);
        }

        public StaticTransferSchedule GetById(string id)
        {
            return StaticTransferScheduleService.GetById(id);
        }

        public List<StaticTransferSchedule> GetAll()
        {
            return StaticTransferScheduleService.GetAll();
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
   
      public StaticTransferScheduleService staticTransferScheduleService;
   */
    }
}