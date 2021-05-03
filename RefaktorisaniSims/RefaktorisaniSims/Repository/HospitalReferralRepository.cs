/***********************************************************************
 * Module:  HospitalReferral.cs
 * Author:  Remica
 * Purpose: Definition of the Class Model.HospitalReferral
 ***********************************************************************/

using Model;
using Newtonsoft.Json;
using System; using System.Collections.Generic;
using System.IO;

namespace Repository
{
   public class HospitalReferralRepository
   {
        private readonly string fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\RefaktorisaniSims\\Data\\hospitalReferrals.json";//D:\Ovde radi sims\RefaktorisaniSims\RefaktorisaniSims\Data\hospitalReferrals.json
        public List<HospitalReferral> hospitalReferrals = new List<HospitalReferral>();

        public HospitalReferralRepository()
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
                    hospitalReferrals = JsonConvert.DeserializeObject<List<HospitalReferral>>(json);
                }
            }
        }

        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(hospitalReferrals);
            File.WriteAllText(fileLocation, json);
        }
        public void Save(HospitalReferral hospitalReferral)
        {
            ReadJson();
            hospitalReferrals.Add(hospitalReferral);
            WriteToJson();
        }

        public void Delete(string id)
        {
            ReadJson();

            int index = hospitalReferrals.FindIndex(obj => obj.Id == id);
            hospitalReferrals.RemoveAt(index);
            WriteToJson();
        }

        public void Update(HospitalReferral hospitalReferral)
        {
            ReadJson();
            int index = hospitalReferrals.FindIndex(obj => obj.Id == hospitalReferral.Id);
            hospitalReferrals[index] = hospitalReferral;
            WriteToJson();
        }
        public HospitalReferral GetById(String id)
        {
            // TODO: implement
            ReadJson();
            return hospitalReferrals.Find(obj => obj.Id == id);
        }
        public List<HospitalReferral> GetAll()
        {
            ReadJson();
            return hospitalReferrals;
        }
        /*
      public void Create(String id, String patientId, String toDoctorId, String fromDoctorId, String explanation)
      {
         // TODO: implement
      }
      
      public void Update(String id, String toDoctorId, String fromDoctorId, String explanation)
      {
         // TODO: implement
      }
      
      public List<HospitalReferral> GetByPatientId(String patientId)
      {
         // TODO: implement
         return null;
      }
      
      public List<HospitalReferral> GetByToDoctorId(String toDoctorId)
      {
         // TODO: implement
         return null;
      }
      
      public void DeleteById(String id)
      {
         // TODO: implement
      }
   */
    }
}