/***********************************************************************
 * Module:  MedicineNotification.cs
 * Author:  Remica
 * Purpose: Definition of the Class Model.MedicineNotification
 ***********************************************************************/

using Model; using System; using System.Collections.Generic;

namespace Repository
{
   public class NotificationBoardRepository
   {
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
      
      public NotificationBoardRepository GetById(String patientId)
      {
         // TODO: implement
         return null;
      }
   
   }
}