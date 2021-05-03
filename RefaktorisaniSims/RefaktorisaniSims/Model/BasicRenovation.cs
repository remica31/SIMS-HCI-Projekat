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
      public String Id;
      public DateTime Date;
      public String RoomId;
      
      public Room[] room;
   
   }
}