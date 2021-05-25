/***********************************************************************
 * Module:  MedicineNotification.cs
 * Author:  Remica
 * Purpose: Definition of the Class Model.MedicineNotification
 ***********************************************************************/

using Model;
using Repository;
using System; using System.Collections.Generic;

namespace Service
{
   public class NotificationBoardService
   {
        public NotificationBoardRepository notificationBoardRepository = new NotificationBoardRepository();


        public List<NotificationBoard> GetAll()
        {
            return notificationBoardRepository.GetAll();
        }

        public NotificationBoard GetById(string id)
        {
            return notificationBoardRepository.GetById(id);
        }

        public void Save(NotificationBoard notificationBoard)
        {
            notificationBoardRepository.Save(notificationBoard);


        }

        public void Delete(string id)
        {
            notificationBoardRepository.Delete(id);
        }

        public void Update(NotificationBoard notificationBoard)
        {
            notificationBoardRepository.Update(notificationBoard);

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
      }
   
        */

    }
}