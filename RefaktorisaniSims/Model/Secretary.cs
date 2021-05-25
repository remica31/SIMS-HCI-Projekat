/***********************************************************************
 * Module:  Secretary.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Secretary
 ***********************************************************************/

using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class Secretary
   {
      public System.Collections.ArrayList notificationBoard;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetNotificationBoard()
      {
         if (notificationBoard == null)
            notificationBoard = new System.Collections.ArrayList();
         return notificationBoard;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetNotificationBoard(System.Collections.ArrayList newNotificationBoard)
      {
         RemoveAllNotificationBoard();
         foreach (NotificationBoard oNotificationBoard in newNotificationBoard)
            AddNotificationBoard(oNotificationBoard);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddNotificationBoard(NotificationBoard newNotificationBoard)
      {
         if (newNotificationBoard == null)
            return;
         if (this.notificationBoard == null)
            this.notificationBoard = new System.Collections.ArrayList();
         if (!this.notificationBoard.Contains(newNotificationBoard))
            this.notificationBoard.Add(newNotificationBoard);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveNotificationBoard(NotificationBoard oldNotificationBoard)
      {
         if (oldNotificationBoard == null)
            return;
         if (this.notificationBoard != null)
            if (this.notificationBoard.Contains(oldNotificationBoard))
               this.notificationBoard.Remove(oldNotificationBoard);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllNotificationBoard()
      {
         if (notificationBoard != null)
            notificationBoard.Clear();
      }
      public User user;
   
   }
}