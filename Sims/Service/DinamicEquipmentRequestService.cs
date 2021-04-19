/***********************************************************************
 * Module:  DinamicEquipmentRequest.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.DinamicEquipmentRequest
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;

namespace Service
{
   public class DinamicEquipmentRequestService
   {
      public void Create(String newId, String newName, String newDate, Model.StatusType newStatusType)
      {
         // TODO: implement
      }
      
      public void Update(String newName, Model.StatusType newStatusType, String newDate)
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
   
      public DinamicEquipmentRequestRepository dinamicEquipmentRequestRepository;
   
   }
}