/***********************************************************************
 * Module:  StaticEquipment.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.StaticEquipment
 ***********************************************************************/

using Model; using System; using System.Collections.Generic;

namespace Model
{
    public class StaticEquipment
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public int Quantity { get; set; }
        public String RoomId { get; set; }
   
   }
}