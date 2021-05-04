/***********************************************************************
 * Module:  MedicineNotification.cs
 * Author:  Remica
 * Purpose: Definition of the Class Model.MedicineNotification
 ***********************************************************************/

using Model;
using Service;
using System; using System.Collections.Generic;

namespace Controller
{
   public class NotificationBoardController
   {
        private NotificationBoardService notificationBoardService = new NotificationBoardService();

        public List<NotificationBoard> GetAll()
        {
            return notificationBoardService.GetAll();
        }

        public NotificationBoard GetById(string id)
        {
            return notificationBoardService.GetById(id);
        }

        public void Save(NotificationBoard notificationBoard)
        {
            notificationBoardService.Save(notificationBoard);
        }

        public void Delete(string id)
        {
            notificationBoardService.Delete(id);
        }

        public void Update(NotificationBoard notificationBoard)
        {
            notificationBoardService.Update(notificationBoard);
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
      }
   
     
   */
    }
}