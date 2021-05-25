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
   public class NotificationBoardRepository
   {

        private readonly string fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\RefaktorisaniSims\\Data\\notificationBoards.json";//D:\Ovde radi sims\RefaktorisaniSims\RefaktorisaniSims\Data\notificationBoards.json
        public List<NotificationBoard> notificationBoards = new List<NotificationBoard>();

        public NotificationBoardRepository()
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
                    notificationBoards = JsonConvert.DeserializeObject<List<NotificationBoard>>(json);
                }
            }
        }

        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(notificationBoards);
            File.WriteAllText(fileLocation, json);
        }
        public void Save(NotificationBoard notificationBoard)
        {
            ReadJson();
            notificationBoards.Add(notificationBoard);
            WriteToJson();
        }

        public void Delete(string id)
        {
            ReadJson();

            int index = notificationBoards.FindIndex(obj => obj.Id == id);
            notificationBoards.RemoveAt(index);
            WriteToJson();
        }

        public void Update(NotificationBoard notificationBoard)
        {
            ReadJson();
            int index = notificationBoards.FindIndex(obj => obj.Id == notificationBoard.Id);
            notificationBoards[index] = notificationBoard;
            WriteToJson();
        }
        public NotificationBoard GetById(String id)
        {
            // TODO: implement
            ReadJson();
            return notificationBoards.Find(obj => obj.Id == id);
        }
        public List<NotificationBoard> GetAll()
        {
            ReadJson();
            return notificationBoards;
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
      }
   */
    }
}