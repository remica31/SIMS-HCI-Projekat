/***********************************************************************
 * Module:  Renovation.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Renovation
 ***********************************************************************/

using Model;
using Newtonsoft.Json;
using System; using System.Collections.Generic;
using System.IO;

namespace Repository
{
   public class BasicRenovationRepository
   {
        private readonly string fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\RefaktorisaniSims\\Data\\basicRenovation.json";
        public List<BasicRenovation> BasicRenovations = new List<BasicRenovation>();
   
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
                    BasicRenovations = JsonConvert.DeserializeObject<List<BasicRenovation>>(json);
                }
            }
        }

        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(BasicRenovations);
            File.WriteAllText(fileLocation, json);
        }

        public void Save(BasicRenovation dr)
        {
            ReadJson();
            BasicRenovations.Add(dr);
            WriteToJson();
        }

        public void Delete(string id)
        {
            ReadJson();

            int index = BasicRenovations.FindIndex(obj => obj.Id == id);
            BasicRenovations.RemoveAt(index);
            WriteToJson();
        }

        public void Update(BasicRenovation dr)
        {
            ReadJson();
            int index = BasicRenovations.FindIndex(obj => obj.Id == dr.Id);
            BasicRenovations[index] = dr;
            WriteToJson();
        }
        public BasicRenovation GetById(String id)
        {
            // TODO: implement
            ReadJson();
            return BasicRenovations.Find(obj => obj.Id == id);
        }
        public List<BasicRenovation> GetAll()
        {
            ReadJson();
            return BasicRenovations;
        }
        /*
      public void Create(String id, DateTime date, String BasicRenovationId)
      {
         // TODO: implement
      }
      
      public void Update(String id, DateTime date)
      {
         // TODO: implement
      }
      
      public void Delete(String id)
      {
         // TODO: implement
      }
      
      public BasicRenovationRepository GetById(String id)
      {
         // TODO: implement
         return null;
      }
      
      public List<BasicRenovation> GetAll()
      {
         // TODO: implement
         return null;
      }*/

    }
}