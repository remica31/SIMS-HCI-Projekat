/***********************************************************************
 * Module:  DinamicEquipmentRequest.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.DinamicEquipmentRequest
 ***********************************************************************/

using Model;
using Repository;
using System; using System.Collections.Generic;
using System.Windows;

namespace Service
{
   public class DynamicEquipmentRequestService
   {
        public DynamicEquipmentRequestRepository dynamicEquipmentRequestRepository = new DynamicEquipmentRequestRepository();

        public void Save(DynamicEquipmentRequest dr)
        {
            List<DynamicEquipmentRequest> requests = dynamicEquipmentRequestRepository.GetAll();
            bool idExists = false;
            foreach (var req in requests)
            {
                if (dr.Id == req.Id)
                {
                    MessageBox.Show("Id already exists!");
                    idExists = true;

                }
            }
            if (!idExists)
            {
                dynamicEquipmentRequestRepository.Save(dr);
            }
        }

        public void Delete(string id)
        {
            dynamicEquipmentRequestRepository.Delete(id);
        }

        public DynamicEquipmentRequest GetById(string id)
        {
            return dynamicEquipmentRequestRepository.GetById(id);
        }

        public void Update(DynamicEquipmentRequest dr)
        {
            dynamicEquipmentRequestRepository.Update(dr);
        }

        public List<DynamicEquipmentRequest> GetAll()
        {
            return dynamicEquipmentRequestRepository.GetAll();
        }

        

        public List<DynamicEquipmentRequest> SearchByName(String name)
        {
            return dynamicEquipmentRequestRepository.SearchByName(name);
        }

        public List<DynamicEquipmentRequest> SearchByStatus(String status)
        {
            return dynamicEquipmentRequestRepository.SearchByStatus(status);
        }

        public List<DynamicEquipmentRequest> SearchByNameAndStatus(String name, String status)
        {
            return dynamicEquipmentRequestRepository.SearchByNameAndStatus(name, status);
        }

        public List<DynamicEquipmentRequest> SortByDate(List<DynamicEquipmentRequest> reqs)
        {
            return dynamicEquipmentRequestRepository.SortByDate(reqs);
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