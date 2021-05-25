// File:    Allergen.cs
// Author:  LENOVO
// Created: Friday, April 9, 2021 20:59:39
// Purpose: Definition of Class Allergen

using Model;
using Newtonsoft.Json;
using System; using System.Collections.Generic;
using System.IO;

namespace Repository
{
   public class AnamnesisRepository
   {
        private readonly string fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\RefaktorisaniSims\\Data\\anamnesiss.json";//D:\Ovde radi sims\RefaktorisaniSims\RefaktorisaniSims\Data\anamnesiss.json
        public List<Anamnesis> anamnesiss = new List<Anamnesis>();

        public AnamnesisRepository()
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
                    anamnesiss = JsonConvert.DeserializeObject<List<Anamnesis>>(json);
                }
            }
        }

        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(anamnesiss);
            File.WriteAllText(fileLocation, json);
        }
        public void Save(Anamnesis anamnesis)
        {
            ReadJson();
            anamnesiss.Add(anamnesis);
            WriteToJson();
        }

        public void Delete(string id)
        {
            ReadJson();

            int index = anamnesiss.FindIndex(obj => obj.Id == id);
            anamnesiss.RemoveAt(index);
            WriteToJson();
        }

        public void Update(Anamnesis anamnesis)
        {
            ReadJson();
            int index = anamnesiss.FindIndex(obj => obj.Id == anamnesis.Id);
            anamnesiss[index] = anamnesis;
            WriteToJson();
        }
        public Anamnesis GetById(String id)
        {
            // TODO: implement
            ReadJson();
            return anamnesiss.Find(obj => obj.Id == id);
        }
        public List<Anamnesis> GetAll()
        {
            ReadJson();
            return anamnesiss;
        }
        /*
      public void Create(String newid, String newName, String newDescription, DateTime newDate)
      {
         // TODO: implement
      }
      
      public void Update(String newid, String newName, String newDescription, DateTime newDate)
      {
         // TODO: implement
      }
      
      public List<Anamnesis> ReadAll()
      {
         // TODO: implement
         return null;
      }
   */
    }
}