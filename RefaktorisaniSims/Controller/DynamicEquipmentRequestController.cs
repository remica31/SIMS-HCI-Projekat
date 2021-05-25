/***********************************************************************
 * Module:  DinamicEquipmentRequest.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.DinamicEquipmentRequest
 ***********************************************************************/

using Model;
using Service;
using System; using System.Collections.Generic;

namespace Controller
{
   public class DynamicEquipmentRequestController
   {
        public DynamicEquipmentRequestService DynamicEquipmentRequestService = new DynamicEquipmentRequestService();

        public void Save(DynamicEquipmentRequest hr)
        {
            DynamicEquipmentRequestService.Save(hr);
        }

        public void Update(DynamicEquipmentRequest hr)
        {
            DynamicEquipmentRequestService.Update(hr);
        }

        public void Delete(string id)
        {
            DynamicEquipmentRequestService.Delete(id);
        }

        public DynamicEquipmentRequest GetById(string id)
        {
            return DynamicEquipmentRequestService.GetById(id);
        }

        public List<DynamicEquipmentRequest> GetAll()
        {
            return DynamicEquipmentRequestService.GetAll();
        }

        public List<DynamicEquipmentRequest> SearchByName(String name)
        {
            return DynamicEquipmentRequestService.SearchByName(name);
        }

        public List<DynamicEquipmentRequest> SearchByStatus(String status)
        {
            return DynamicEquipmentRequestService.SearchByStatus(status);
        }

        public List<DynamicEquipmentRequest> SearchByNameAndStatus(String name, String status)
        {
            return DynamicEquipmentRequestService.SearchByNameAndStatus(name, status);
        }

        public List<DynamicEquipmentRequest> SortByDate(List<DynamicEquipmentRequest> reqs)
        {
            return DynamicEquipmentRequestService.SortByDate(reqs);
        }
        /*
      public void Create(String newId, String newName, DateTime newDate, Model.StatusType newStatusType)
      {
         // TODO: implement
      }
      
      public void Update(String newName, Model.StatusType newStatusType, DateTime newDate)
      {
         // TODO: implement
      }
      
      public void Delete(String id)
      {
         // TODO: implement
      }
      
      public List<DynamicEquipmentRequest> ReadAll()
      {
         // TODO: implement
         return null;
      }
      
      public DynamicEquipmentRequest ReadById(String id)
      {
         // TODO: implement
         return null;
      }
      
      public List<DynamicEquipmentRequest> SearchByName(String name)
      {
         // TODO: implement
         return null;
      }
      
      public List<DynamicEquipmentRequest> SearchByStatus(Model.StatusType status)
      {
         // TODO: implement
         return null;
      }*/



    }
}