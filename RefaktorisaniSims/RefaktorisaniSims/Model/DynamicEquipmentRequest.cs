/***********************************************************************
 * Module:  DynamicEquipmentRequest.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.DynamicEquipmentRequest
 ***********************************************************************/

using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class DynamicEquipmentRequest
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public DateTime Date { get; set; }
        public String Status { get; set; }
        public String WardensComment { get; set; }

    }
}