/***********************************************************************
 * Module:  Warehouse.cs
 * Author:  Remica
 * Purpose: Definition of the Class Model.Warehouse
 ***********************************************************************/

using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class Warehouse
   {
      public String Id;
      public String Name;
      
      public DynamicEquipment[] dynamicEquipment;
   
   }
}