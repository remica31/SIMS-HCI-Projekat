/***********************************************************************
 * Module:  MedicineNotificationController.cs
 * Author:  Remica
 * Purpose: Definition of the Class Controller.MedicineNotificationController
 ***********************************************************************/

using Model;
using Newtonsoft.Json;
using System; using System.Collections.Generic;
using System.IO;

namespace Repository
{

   public class MedicineNotificationRepository
   {
        private readonly string fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\RefaktorisaniSims\\Data\\medicineNotifications.json";//D:\Ovde radi sims\RefaktorisaniSims\RefaktorisaniSims\Data\medicineNotifications.json
        public List<MedicineNotification> medicineNotifications = new List<MedicineNotification>();

        public MedicineNotificationRepository()
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
                    medicineNotifications = JsonConvert.DeserializeObject<List<MedicineNotification>>(json);
                }
            }
        }

        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(medicineNotifications);
            File.WriteAllText(fileLocation, json);
        }
        public void Save(MedicineNotification medicineNotification)
        {
            ReadJson();
            medicineNotifications.Add(medicineNotification);
            WriteToJson();
        }

        public void Delete(string id)
        {
            ReadJson();

            int index = medicineNotifications.FindIndex(obj => obj.Id == id);
            medicineNotifications.RemoveAt(index);
            WriteToJson();
        }

        public void Update(MedicineNotification medicineNotification)
        {
            ReadJson();
            int index = medicineNotifications.FindIndex(obj => obj.Id == medicineNotification.Id);
            medicineNotifications[index] = medicineNotification;
            WriteToJson();
        }
        public MedicineNotification GetById(String id)
        {
            // TODO: implement
            ReadJson();
            return medicineNotifications.Find(obj => obj.Id == id);
        }
        public List<MedicineNotification> GetAll()
        {
            ReadJson();
            return medicineNotifications;
        }
        /*
      public void Create(String id, DateTime start, DateTime finish, int step, String description)
      {
         // TODO: implement
      }
      
      public int Update(DateTime newStart, DateTime newFinish, String newId, int newStep, String newDescription)
      {
         // TODO: implement
         return 0;
      }
      
      public int Delete()
      {
         // TODO: implement
         return 0;
      }
      
      public List<MedicineNotification> GetAll()
      {
         // TODO: implement
         return null;
      }
      
      public List<MedicineNotification> GetByPatientId(String patientId)
      {
         // TODO: implement
         return null;
      }
   */
    }
}