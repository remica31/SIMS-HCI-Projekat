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
      public string Id { get; set; }
      public int Number { get; set; }
      public String Type { get; set; }
      public int Floor { get; set; }
      public String Description { get; set; }
      
      public BasicRenovation[] basicRenovation { get; set; }
      public Doctor doctor { get; set;}
   
   }
}