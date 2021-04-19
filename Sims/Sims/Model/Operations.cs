/***********************************************************************
 * Module:  Operations.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.Operations
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;

namespace Model
{
   public class Operations
   {
      public void Create(String inewd, double newStart, double newDuration, Room newRoom)
      {
         // TODO: implement
      }
      
      public void Update(String id, double start, double duration, Room room)
      {
         // TODO: implement
      }
      
      public void Delete()
      {
         // TODO: implement
      }
      
      public List<Operations> GetAll()
      {
         // TODO: implement
         return null;
      }
      
      public Operations GetByid()
      {
         // TODO: implement
         return null;
      }
   
      public String Id;
      public Double Start;
      public Double Duration;
      public Room Room;
      
      public Room room;
   
   }
}