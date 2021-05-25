/***********************************************************************
 * Module:  DinamicEquipmentRequest.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.DinamicEquipmentRequest
 ***********************************************************************/

using Model;
using Newtonsoft.Json;
using System; using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Repository
{
    public class DynamicEquipmentRequestRepository
    {
        private readonly string fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\RefaktorisaniSims\\Data\\dynamicEquipmentRequests.json";
        public List<DynamicEquipmentRequest> requests = new List<DynamicEquipmentRequest>();

        public DynamicEquipmentRequestRepository()
        {
            ReadJson();
        }

        public void ReadJson()
        {
            if (!File.Exists(fileLocation))
            {
                File.Create(fileLocation).Close();
            }

            using (StreamReader r = new StreamReader(fileLocation))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    requests = JsonConvert.DeserializeObject<List<DynamicEquipmentRequest>>(json);
                }
            }
        }

        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(requests);
            File.WriteAllText(fileLocation, json);
        }

        public void Save(DynamicEquipmentRequest dr)
        {
            ReadJson();
            requests.Add(dr);
            WriteToJson();
        }

        public void Delete(string id)
        {
            ReadJson();

            int index = requests.FindIndex(obj => obj.Id == id);
            requests.RemoveAt(index);
            WriteToJson();
        }

        public void Update(DynamicEquipmentRequest dr)
        {
            ReadJson();
            int index = requests.FindIndex(obj => obj.Id == dr.Id);
            requests[index] = dr;
            WriteToJson();
        }
        public DynamicEquipmentRequest GetById(String id)
        {
            // TODO: implement
            ReadJson();
            return requests.Find(obj => obj.Id == id);
        }
        public List<DynamicEquipmentRequest> GetAll()
        {
            ReadJson();
            return requests;
        }

        public void swap(DynamicEquipmentRequest x, DynamicEquipmentRequest y)
        {
            var temp = x;
            x = y;
            y = temp;
        }

        public List<DynamicEquipmentRequest> SortByDate(List<DynamicEquipmentRequest> sortedrequests)
        {
            sortedrequests.Sort((x, y) => DateTime.Compare(x.Date, y.Date));
            return sortedrequests;
        }

        public List<DynamicEquipmentRequest> SearchByName(String name)
        {
            ReadJson();
            var newReqs = new List<DynamicEquipmentRequest>();
            foreach (var eq in requests)
            {
                if (name == eq.Name)
                {
                    newReqs.Add(eq);
                }
            }
            
            return newReqs;
        }

        public List<DynamicEquipmentRequest> SearchByStatus(String status)
        {
            ReadJson();
            var newReqs = new List<DynamicEquipmentRequest>();
            foreach (var eq in requests)
            {
                if (eq.Status == status)
                {
                    newReqs.Add(eq);
                }
            }
            
            return newReqs;
        }

        public List<DynamicEquipmentRequest> SearchByNameAndStatus(String name, String status)
        {
            ReadJson();
            var newReqs = new List<DynamicEquipmentRequest>();
            foreach (var req in requests)
            {
                if (req.Name == name && req.Status == status)
                {
                    newReqs.Add(req);
                }
            }
            
            return newReqs;
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