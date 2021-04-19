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
        public void Create(String newId, String newName, String newDate, string newStatusType)
        {
            var req = new DinamicEquipmentRequest();
            req.Id = newId;
            req.Name = newName;
            req.Date = newDate;
            req.StatusType = newStatusType;
            requests.Add(req);
        }

        public void Update(String newName, string newStatusType, String newDate)
        {
            Name = newName;
            StatusType = newStatusType;
            Date = newDate;
        }

        public void Delete(String id)
        {
            foreach (var req in requests)
            {
                if (req.Id == id)
                {
                    requests.Remove(req);
                }
            }
        }

        public List<DinamicEquipmentRequest> ReadAll()
        {
            return requests;

        }

        public DinamicEquipmentRequest ReadById(String id)
        {
            foreach (var req in requests)
            {
                if (req.Id == id)
                {
                    return req;
                }
            }
            return null;
        }

        public String Id { get; set; }
        public String Name { get; set; }
        public String Date { get; set; }
        public string StatusType { get; set; }
        public String WardensComment {get; set;}
        List<DinamicEquipmentRequest> requests = new List<DinamicEquipmentRequest>();
   
        
   }
}