/***********************************************************************
 * Module:  Medicine.cs
 * Author:  Remica
 * Purpose: Definition of the Class Model.Medicine
 ***********************************************************************/

using Model;
using Newtonsoft.Json;
using System; using System.Collections.Generic;
using System.IO;

namespace Repository
{
   public class MedicineRepository
   {

        private readonly string fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\RefaktorisaniSims\\Data\\medicines.json";//D:\Ovde radi sims\RefaktorisaniSims\RefaktorisaniSims\Data\medicines.json
        public List<Medicine> medicines = new List<Medicine>();

        public MedicineRepository()
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
                    medicines = JsonConvert.DeserializeObject<List<Medicine>>(json);
                }
            }
        }

        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(medicines);
            File.WriteAllText(fileLocation, json);
        }
        public void Save(Medicine medicine)
        {
            ReadJson();
            medicines.Add(medicine);
            WriteToJson();
        }

        public void Delete(string id)
        {
            ReadJson();

            int index = medicines.FindIndex(obj => obj.Id == id);
            medicines.RemoveAt(index);
            WriteToJson();
        }

        public void Update(Medicine medicine)
        {
            ReadJson();
            int index = medicines.FindIndex(obj => obj.Id == medicine.Id);
            medicines[index] = medicine;
            WriteToJson();
        }
        public Medicine GetById(String id)
        {
            // TODO: implement
            ReadJson();
            return medicines.Find(obj => obj.Id == id);
        }
        public List<Medicine> GetAll()
        {
            ReadJson();
            return medicines;
        }

        public List<Medicine> GetAllByStatus(string status)
        {
            ReadJson();
            List<Medicine> returnMedicines = new List<Medicine>();
            foreach(var medicine in medicines)
            {
                if (medicine.Status == status)
                {
                    returnMedicines.Add(medicine);
                }
            }
            return returnMedicines;
        }
        /*
      public Medicine ReadById(String id)
      {
         // TODO: implement
         return null;
      }
      
      public List<Medicine> ReadAll()
      {
         // TODO: implement
         return null;
      }
      
      public List<Medicine> GetAllByStatus(String status)
      {
         // TODO: implement
         return null;
      }
      
      public void Update(String id, String description, String status, String doctorComment, String ingredients)
      {
         // TODO: implement
      }
      
      public void Create(String id, String name, String description, String status, String ingredients)
      {
         // TODO: implement
      }
      
      public void Delete(String id)
      {
         // TODO: implement
      }
   */
    }
}