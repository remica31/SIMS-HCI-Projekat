/***********************************************************************
 * Module:  StaticEquipments.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.StaticEquipments
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;

namespace Model
{
   public class DinamicEquipments
   {
      public List<DinamicEquipments> GetAll()
      {
         // TODO: implement
         return null;
      }
      
      public DinamicEquipments GetById()
      {
         // TODO: implement
         return null;
      }
      
      public void Delete(String id)
      {
         // TODO: implement
      }
      
      public void Update(String id, String name, String werehouse, int quantity)
      {
         // TODO: implement
      }
      
      public void Create(String id, String name, String werehouse, int quantity)
      {
         // TODO: implement
      }
   
      public String Id;
      public String Name;
      public Werehouse Werehouse;
      public int Quntity;
      
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