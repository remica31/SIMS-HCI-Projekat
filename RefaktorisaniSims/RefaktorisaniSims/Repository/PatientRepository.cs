/***********************************************************************
 * Module:  Patient.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Patient
 ***********************************************************************/

using Model;
using Newtonsoft.Json;
using System; using System.Collections.Generic;
using System.IO;

namespace Repository
{
   public class PatientRepository
   {
        private readonly string fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\RefaktorisaniSims\\Data\\patients.json";
        private List<Patient> patients = new List<Patient>();

        public PatientRepository()
        {
            ReadJson();
        }

        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(patients);
            File.WriteAllText(fileLocation, json);
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
                    patients = JsonConvert.DeserializeObject<List<Patient>>(json);
                }
            }
        }

        public List<Patient> GetAll()
        {
            ReadJson();
            return patients;
        }

        public Patient GetById(String id)
        {
            ReadJson();
            return patients.Find(obj => obj.User.Id == id);
        }

        public void Save(Patient patient)
        {
            ReadJson();
            patients.Add(patient);
            WriteToJson();
        }

        public void Delete(String Id)
        {
            ReadJson();
            int index = patients.FindIndex(obj => obj.User.Id == Id);
            patients.RemoveAt(index);
            WriteToJson();
        }

        /*
      public List<Patient> GetAll()
      {
         // TODO: implement
         return null;
      }
      
      public PatientRepository GetById(String id)
      {
         // TODO: implement
         return null;
      }
      
      public void Create(String newJmbg, String newUsername, String newPassword, String newID, String newName, String newSurname, String newEMail, String newAddress, String newPhone)
      {
         // TODO: implement
      }
      
      public void Update(String newEmail, String newAddress, String newPhone)
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