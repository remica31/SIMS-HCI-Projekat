/***********************************************************************
 * Module:  StaticEquipments.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.StaticEquipments
 ***********************************************************************/

using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class DynamicEquipment
   {
      public String Id { get; set; }
      public String Name { get; set; }
      public String WarehouseId { get; set; }
      public int Quantity { get; set; }

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
   
   }
}