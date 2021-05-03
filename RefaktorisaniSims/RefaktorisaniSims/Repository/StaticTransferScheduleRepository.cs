/***********************************************************************
 * Module:  StaticTransferSchedule.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.StaticTransferSchedule
 ***********************************************************************/

using Model;
using Newtonsoft.Json;
using System; using System.Collections.Generic;
using System.IO;

namespace Repository
{
   public class StaticTransferScheduleRepository
   {
        private readonly string fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\RefaktorisaniSims\\Data\\dyntransfer.json";
        public List<StaticTransferSchedule> staticeq = new List<StaticTransferSchedule>();

        public StaticTransferScheduleRepository()
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
                    staticeq = JsonConvert.DeserializeObject<List<StaticTransferSchedule>>(json);
                }
            }
        }

        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(staticeq);
            File.WriteAllText(fileLocation, json);
        }

        public void Save(StaticTransferSchedule dr)
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

        public void Update(StaticTransferSchedule dr)
        {
            ReadJson();
            int index = staticeq.FindIndex(obj => obj.Id == dr.Id);
            staticeq[index] = dr;
            WriteToJson();
        }
        public StaticTransferSchedule GetById(String id)
        {
            // TODO: implement
            ReadJson();
            return staticeq.Find(obj => obj.Id == id);
        }
        public List<StaticTransferSchedule> GetAll()
        {
            ReadJson();
            return staticeq;
        }
        /*
      public void Create(String newid, DateTime newDate)
      {
         // TODO: implement
      }
      
      public List<StaticTransferSchedule> ReadAll()
      {
         // TODO: implement
         return null;
      }
      
      public StaticTransferSchedule ReadById(String id)
      {
         // TODO: implement
         return null;
      }*/

    }
}