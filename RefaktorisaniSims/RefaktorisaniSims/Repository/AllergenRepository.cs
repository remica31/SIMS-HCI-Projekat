/***********************************************************************
 * Module:  AllergenController.cs
 * Author:  Remica
 * Purpose: Definition of the Class Controller.AllergenController
 ***********************************************************************/

using Model;
using Newtonsoft.Json;
using System; using System.Collections.Generic;
using System.IO;

namespace Repository
{
   public class AllergenRepository
   {
        private readonly string fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\RefaktorisaniSims\\Data\\allergens.json";//D:\Ovde radi sims\RefaktorisaniSims\RefaktorisaniSims\Data\allergens.json
        public List<Allergen> allergens = new List<Allergen>();

        public AllergenRepository()
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
                    allergens = JsonConvert.DeserializeObject<List<Allergen>>(json);
                }
            }
        }

        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(allergens);
            File.WriteAllText(fileLocation, json);
        }
        public void Save(Allergen allergen)
        {
            ReadJson();
            allergens.Add(allergen);
            WriteToJson();
        }

        public void Delete(string id)
        {
            ReadJson();

            int index = allergens.FindIndex(obj => obj.Id == id);
            allergens.RemoveAt(index);
            WriteToJson();
        }

        public void Update(Allergen allergen)
        {
            ReadJson();
            int index = allergens.FindIndex(obj => obj.Id == allergen.Id);
            allergens[index] = allergen;
            WriteToJson();
        }
        public Allergen GetById(String id)
        {
            // TODO: implement
            ReadJson();
            return allergens.Find(obj => obj.Id == id);
        }
        public List<Allergen> GetAll()
        {
            ReadJson();
            return allergens;
        }
        public List<Allergen> GetByPatient(string id)
        {
            List<Allergen> newAllergens = new List<Allergen>();
            foreach(var all in allergens)
            {
                if (all.PatientId == id)
                {
                    newAllergens.Add(all);
                }
            }
            return newAllergens;
        }
        /*
      public void Create(String newId, String newName, String newDescription)
      {
         // TODO: implement
      }
      
      public void Update(String newId, String newName, String newDescription)
      {
         // TODO: implement
      }
      
      public List<Allergen> ReadAll()
      {
         // TODO: implement
         return null;
      }
      
      public Allergen ReadById(String id)
      {
         // TODO: implement
         return null;
      }
      
      public void Delete()
      {
         // TODO: implement
      }
   */
    }
}