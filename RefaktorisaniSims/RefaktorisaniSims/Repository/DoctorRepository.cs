/***********************************************************************
 * Module:  Doctor.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Doctor
 ***********************************************************************/

using Model;
using Newtonsoft.Json;
using System; using System.Collections.Generic;
using System.IO;

namespace Repository
{
   public class DoctorRepository
   {
        private readonly string fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\RefaktorisaniSims\\Data\\doctors.json";//Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Data\\doctors.json";
        private List<Doctor> doctors = new List<Doctor>();

        public DoctorRepository()
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
                    doctors = JsonConvert.DeserializeObject<List<Doctor>>(json);
                }
            }
        }
        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(doctors);
            File.WriteAllText(fileLocation, json);
        }

        public void Create(Model.User user, String specializationtype)
      {
         // TODO: implement
      }
      
      public void Update()
      {
         // TODO: implement
      }
      
      public List<Doctor> GetAll()
      {
           
            return doctors;
      }

        public Doctor GetById(String id)
        {
            return doctors.Find(obj => obj.User.Id == id);
        }
        public void Save(Doctor doctor)
        {
            
            doctors.Add(doctor);
            WriteToJson();
        }

        public void Delete(String id)
        {
            int index = doctors.FindIndex(obj => obj.User.Id == id);
            doctors.RemoveAt(index);
            WriteToJson();
        }

    }
}