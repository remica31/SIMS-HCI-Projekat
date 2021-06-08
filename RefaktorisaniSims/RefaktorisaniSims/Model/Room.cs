/***********************************************************************
 * Module:  Room.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Room
 ***********************************************************************/

using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class Room
   {
       public Room()
        {
            Id = "11";
            Number = 11;
            Type = "Vocation";
            Floor = 5;
            Description = "/";
            beds = new List<Bed>();
        }

        public Room(string id, int number, string type, int floor, string desc)
        {
            this.Id = id;
            this.Number = number;
            this.Type = type;
            this.Floor = floor;
            this.Description = desc;
        }
      public string Id { get; set; }
      public int Number { get; set; }
      public String Type { get; set; }
      public int Floor { get; set; }
      public String Description { get; set; }
      
      public BasicRenovation[] basicRenovation { get; set; }
      public Doctor doctor { get; set;}

        public List<Bed> beds { get; set; }

      
   
   }
}