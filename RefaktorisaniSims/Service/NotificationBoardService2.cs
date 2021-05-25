/***********************************************************************
 * Module:  NotificationBoardNotification.cs
 * Author:  Remica
 * Purpose: Definition of the Class Model.NotificationBoardNotification
 ***********************************************************************/

using Model;
using Repository;
using System; using System.Collections.Generic;

namespace Service
{
   public class NotificationBoardService2
   {
        public NotificationBoardRepository2 NotificationBoardRepository = new NotificationBoardRepository2();


        public List<NotificationBoard2> GetAll()
        {
            return NotificationBoardRepository.GetAll();
        }

        public NotificationBoard2 GetById(string id)
        {
            return NotificationBoardRepository.GetById(id);
        }

        public void Save(NotificationBoard2 NotificationBoard)
        {
            NotificationBoardRepository.Save(NotificationBoard);


        }

        public void Delete(string id)
        {
            NotificationBoardRepository.Delete(id);
        }

        public void Update(NotificationBoard2 NotificationBoard)
        {
            NotificationBoardRepository.Update(NotificationBoard);

        }
        /*
      public void Create(String name, String text, DateTime date)
      {
         // TODO: implement
      }
      
      public void Update(String newId, String newText, DateTime newDate)
      {
         // TODO: implement
      }
      
      public void Delete(int id)
      {
         // TODO: implement
      }
      
      public List<NotificationBoard> GetAll()
      {
         // TODO: implement
         return null;
      }
      
      public NotificationBoardService GetById(String patientId)
      {
         // TODO: implement
         return null;
      }*/



    }
}