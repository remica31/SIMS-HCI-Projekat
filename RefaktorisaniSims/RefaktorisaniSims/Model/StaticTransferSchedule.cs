/***********************************************************************
 * Module:  StaticTransferSchedule.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.StaticTransferSchedule
 ***********************************************************************/

using Model; using System; using System.Collections.Generic;

namespace Model
{
    public class StaticTransferSchedule
    {
        public String Id { get; set; }
        public String EquipmentName {get; set;}
      public int Quantity { get; set; }
        public String WarehouseId;
      
      public System.Collections.ArrayList room;
      
      
   
   }
}