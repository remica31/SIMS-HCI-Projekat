/***********************************************************************
 * Module:  Renovation.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Renovation
 ***********************************************************************/

using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class BasicRenovation
   {
        public BasicRenovation(string id, DateTime date, String rid)
        {
            Id = id;
            Date = date;
            RoomId = rid;
        }
      public String Id { get; set; }
      public DateTime Date { get; set; }
      public String RoomId { get; set; }
      
      public Room[] room { get; set; }
   
   }
}