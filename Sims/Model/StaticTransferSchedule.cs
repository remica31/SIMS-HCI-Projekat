/***********************************************************************
 * Module:  StaticTransferSchedule.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.StaticTransferSchedule
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;

namespace Model
{
   public class StaticTransferSchedule
   {
      public void Create(String newid, String newDate)
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
   
      public String Id;
      public String Date;
      
      public System.Collections.ArrayList room;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetRoom()
      {
         if (room == null)
            room = new System.Collections.ArrayList();
         return room;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetRoom(System.Collections.ArrayList newRoom)
      {
         RemoveAllRoom();
         foreach (Room oRoom in newRoom)
            AddRoom(oRoom);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddRoom(Room newRoom)
      {
         if (newRoom == null)
            return;
         if (this.room == null)
            this.room = new System.Collections.ArrayList();
         if (!this.room.Contains(newRoom))
            this.room.Add(newRoom);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveRoom(Room oldRoom)
      {
         if (oldRoom == null)
            return;
         if (this.room != null)
            if (this.room.Contains(oldRoom))
               this.room.Remove(oldRoom);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllRoom()
      {
         if (room != null)
            room.Clear();
      }
   
      private String RoomId;
      private String StaticEquipmentId;
      private int Quantity;
   
   }
}