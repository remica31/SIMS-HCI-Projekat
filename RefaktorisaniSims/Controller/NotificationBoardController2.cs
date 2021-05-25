/***********************************************************************
 * Module:  NotificationBoardNotification.cs
 * Author:  Remica
 * Purpose: Definition of the Class Model.NotificationBoardNotification
 ***********************************************************************/

using Model;
using Service;
using System; using System.Collections.Generic;

namespace Controller
{
   public class NotificationBoardController2
   {
        private NotificationBoardService2 NotificationBoardService2 = new NotificationBoardService2();

        public List<NotificationBoard2> GetAll()
        {
            return NotificationBoardService2.GetAll();
        }

        public NotificationBoard2 GetById(string id)
        {
            return NotificationBoardService2.GetById(id);
        }

        public void Save(NotificationBoard2 NotificationBoard)
        {
            NotificationBoardService2.Save(NotificationBoard);
        }

        public void Delete(string id)
        {
            NotificationBoardService2.Delete(id);
        }

        public void Update(NotificationBoard2 NotificationBoard)
        {
            NotificationBoardService2.Update(NotificationBoard);
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
      
      public NotificationBoardController GetById(String patientId)
      {
         // TODO: implement
         return null;
      }*/



    }
}