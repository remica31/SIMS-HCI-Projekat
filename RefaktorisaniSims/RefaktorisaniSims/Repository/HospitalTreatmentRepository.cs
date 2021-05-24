/***********************************************************************
 * Module:  HospitalTreatmentRepository.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Repository.HospitalTreatmentRepository
 ***********************************************************************/

using Model;
using Newtonsoft.Json;
using System; using System.Collections.Generic;
using System.IO;

namespace Repository
{
   public class HospitalTreatmentRepository
   {
        private readonly string fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\RefaktorisaniSims\\Data\\treatments.json";//D:\Ovde radi sims\RefaktorisaniSims\RefaktorisaniSims\Data\appointments.json
        public List<HospitalTReatment> treatments = new List<HospitalTReatment>();

        public HospitalTreatmentRepository()
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
                    treatments = JsonConvert.DeserializeObject<List<HospitalTReatment>>(json);
                }
            }
        }

        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(treatments);
            File.WriteAllText(fileLocation, json);
        }
        public void Save(HospitalTReatment treatment)
        {
            ReadJson();
            treatments.Add(treatment);
            WriteToJson();
        }

        public void Delete(int id)
        {
            ReadJson();

            int index = treatments.FindIndex(obj => obj.Id == id);
            treatments.RemoveAt(index);
            WriteToJson();
        }

        public void Update(HospitalTReatment treatment)
        {
            ReadJson();
          
            int index = treatments.FindIndex(obj => obj.Id == treatment.Id);
            treatments[index] = treatment;
            WriteToJson();
        }
        public List<HospitalTReatment> GetAll()
        {
            ReadJson();
            return treatments;
        }
        public HospitalTReatment GetById(int id)
        {
            ReadJson();
            int index = treatments.FindIndex(obj => obj.Id == id);
            return treatments[index];
        }
    }
}