/***********************************************************************
 * Module:  MedicineNotification.cs
 * Author:  Remica
 * Purpose: Definition of the Class Model.MedicineNotification
 ***********************************************************************/

using Model;
using Newtonsoft.Json;
using System; using System.Collections.Generic;
using System.IO;

namespace Repository
{
   public class NotificationBoardRepository2
   {
        private readonly string fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\RefaktorisaniSims\\Data\\staticTransfer.json";
        public List<NotificationBoard2> staticeq = new List<NotificationBoard2>();

        public NotificationBoardRepository2()
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
                    staticeq = JsonConvert.DeserializeObject<List<NotificationBoard2>>(json);
                }
            }
        }

        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(staticeq);
            File.WriteAllText(fileLocation, json);
        }

        public void Save(NotificationBoard2 dr)
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

        public void Update(NotificationBoard2 dr)
        {
            ReadJson();
            int index = staticeq.FindIndex(obj => obj.Id == dr.Id);
            staticeq[index] = dr;
            WriteToJson();
        }
        public NotificationBoard2 GetById(String id)
        {
            // TODO: implement
            ReadJson();
            return staticeq.Find(obj => obj.Id == id);
        }
        public List<NotificationBoard2> GetAll()
        {
            ReadJson();
            return staticeq;
        }
        /*
      public void Create(String name, String text, DateTime date)
      {
         // TODO: implement
      }
      
      public void Update(String newId, String newText, DateTime newDate)
      {
         // TODO: implement
      }
      
      public void Delete(int id)
      {
         // TODO: implement
      }
      
      public List<NotificationBoard> GetAll()
      {
         // TODO: implement
         return null;
      }
      
      public NotificationBoardRepository GetById(String patientId)
      {
         // TODO: implement
         return null;
      }*/

    }
}