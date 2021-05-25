/***********************************************************************
 * Module:  DynamicEquipmentController.cs
 * Author:  Remica
 * Purpose: Definition of the Class Controller.DynamicEquipmentController
 ***********************************************************************/

using Model;
using Newtonsoft.Json;
using System; using System.Collections.Generic;
using System.IO;

namespace Repository
{
   public class DynamicEquipmentRepository
   {
        private readonly string fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\RefaktorisaniSims\\Data\\dynamicequipment.json";
        public List<DynamicEquipment> dyneq = new List<DynamicEquipment>();

        public DynamicEquipmentRepository()
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
                    dyneq = JsonConvert.DeserializeObject<List<DynamicEquipment>>(json);
                }
            }
        }

        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(dyneq);
            File.WriteAllText(fileLocation, json);
        }

        public void Save(DynamicEquipment dr)
        {
            ReadJson();
            dyneq.Add(dr);
            WriteToJson();
        }

        public void Delete(string id)
        {
            ReadJson();

            int index = dyneq.FindIndex(obj => obj.Id == id);
            dyneq.RemoveAt(index);
            WriteToJson();
        }

        public void Update(DynamicEquipment dr)
        {
            ReadJson();
            int index = dyneq.FindIndex(obj => obj.Id == dr.Id);
            dyneq[index] = dr;
            WriteToJson();
        }
        public DynamicEquipment GetById(String id)
        {
            // TODO: implement
            ReadJson();
            return dyneq.Find(obj => obj.Id == id);
        }
        public List<DynamicEquipment> GetAll()
        {
            ReadJson();
            return dyneq;
        }

        public DynamicEquipment GetByName(string name)
        {
            ReadJson();
            foreach (var eq in dyneq)
            {
                if (eq.Name == name)
                {
                    return eq;
                }
            }
            return null;
        }

        /*
      public List<DynamicEquipment> GetAll()
      {
         // TODO: implement
         return null;
      }
      
      public Model.DynamicEquipment GetById(String id)
      {
         // TODO: implement
         return null;
      }
      
      public void Delete(String id)
      {
         // TODO: implement
      }
      
      public void Update(String id, String name, String warehouse, int quantity)
      {
         // TODO: implement
      }
      
      public void Create(String id, String name, String warehouse, int quantity)
      {
         // TODO: implement
      }
      
      public List<DynamicEquipment> SearchByName(String name)
      {
         // TODO: implement
         return null;
      }*/

    }
}