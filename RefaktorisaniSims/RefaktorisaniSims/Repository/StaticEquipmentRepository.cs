/***********************************************************************
 * Module:  StaticEquipments.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.StaticEquipments
 ***********************************************************************/

using Model;
using Newtonsoft.Json;
using System; using System.Collections.Generic;
using System.IO;

namespace Repository
{
   public class StaticEquipmentRepository
   {

        private readonly string fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\RefaktorisaniSims\\Data\\Staticequipment.json";
        public List<StaticEquipment> staticeq = new List<StaticEquipment>();

        public StaticEquipmentRepository()
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
                    staticeq = JsonConvert.DeserializeObject<List<StaticEquipment>>(json);
                }
            }
        }

        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(staticeq);
            File.WriteAllText(fileLocation, json);
        }

        public void Save(StaticEquipment dr)
        {
            ReadJson();
            staticeq.Add(dr);
            WriteToJson();
        }

        public void Delete(string id)
        {
            ReadJson();

            int index = staticeq.FindIndex(obj => obj.Id == id);
            staticeq.RemoveAt(index);
            WriteToJson();
        }

        public void Update(StaticEquipment dr)
        {
            ReadJson();
            int index = staticeq.FindIndex(obj => obj.Id == dr.Id);
            staticeq[index] = dr;
            WriteToJson();
        }
        public StaticEquipment GetById(String id)
        {
            // TODO: implement
            ReadJson();
            return staticeq.Find(obj => obj.Id == id);
        }
        public List<StaticEquipment> GetAll()
        {
            ReadJson();
            return staticeq;
        }

        public List<StaticEquipment> GetAllByName(string name) {
            var newEq = new List<StaticEquipment>();
            foreach (var eq in staticeq)
            {
                if (name == eq.Name)
                {
                    newEq.Add(eq);
                }
            }
            return newEq;
        }

        public List<StaticEquipment> GetAllByRoomId(string id)
        {
            var newEq = new List<StaticEquipment>();
            foreach (var eq in staticeq)
            {
                if (id == eq.RoomId)
                {
                    newEq.Add(eq);
                }
            }
            return newEq;
        }

        /*
      public void Delete(String id)
      {
         // TODO: implement
      }
      
      public void Update(String id, String name, String warehouseId, int quantity)
      {
         // TODO: implement
      }
      
      public void Create(String newFromRoomId, DateTime newDate, String newToRoomId)
      {
         // TODO: implement
      }
      
      public List<StaticTransferSchedule> ReadAll()
      {
         // TODO: implement
         return null;
      }
      
      public Model.StaticTransferSchedule ReadById(String id)
      {
         // TODO: implement
         return null;
      }
      
      public List<StaticEquipment> SearchByName(String name)
      {
         // TODO: implement
         return null;
      }*/

    }
}