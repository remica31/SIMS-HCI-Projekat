/***********************************************************************
 * Module:  DinamicEquipmentRequest.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.DinamicEquipmentRequest
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;

namespace Model
{
   public class DinamicEquipmentRequest
   {
      public void Create(String newId, String newName, String newDate, StatusType newStatusType)
      {
         // TODO: implement
      }
      
      public void Update(String newName, StatusType newStatusType, String newDate)
      {
         // TODO: implement
      }
      
      public void Delete(String id)
      {
         // TODO: implement
      }
      
      public List<DinamicEquipmentRequest> ReadAll()
      {
         // TODO: implement
         return null;
      }
      
      public DinamicEquipmentRequest ReadById(String id)
      {
         // TODO: implement
         return null;
      }
   
      public String Id { set; get; }
      public String Name { set; get; }
        public String Date { set; get; }
        public String StatusType { set; get; }
        public String WardensComment { set; get; }

    }
}