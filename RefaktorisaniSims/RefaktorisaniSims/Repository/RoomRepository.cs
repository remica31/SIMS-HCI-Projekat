/***********************************************************************
 * Module:  RoomRepository.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Repository.RoomRepository
 ***********************************************************************/

using Controller;
using Model;
using Newtonsoft.Json;
using System; using System.Collections.Generic;
using System.IO;

namespace Repository
{
   public class RoomRepository
   {
        private readonly string fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\RefaktorisaniSims\\Data\\rooms.json";
        public List<Room> rooms = new List<Room>();
        public List<StaticEquipment> eq = new List<StaticEquipment>();
        public StaticEquipmentController c = new StaticEquipmentController();
        

        public RoomRepository()
        {
            ReadJson();
            eq = c.GetAll();
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
                    rooms = JsonConvert.DeserializeObject<List<Room>>(json);
                }
            }
        }

        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(rooms);
            File.WriteAllText(fileLocation, json);
        }

        public void Save(Room dr)
        {
            ReadJson();
            rooms.Add(dr);
            WriteToJson();
        }

        public void Delete(string id)
        {
            ReadJson();

            int index = rooms.FindIndex(obj => obj.Id == id);
            rooms.RemoveAt(index);
            WriteToJson();
        }

        public void Update(Room dr)
        {
            ReadJson();
            int index = rooms.FindIndex(obj => obj.Id == dr.Id);
            rooms[index] = dr;
            WriteToJson();
        }
        public Room GetById(String id)
        {
            // TODO: implement
            ReadJson();
            return rooms.Find(obj => obj.Id == id);
        }
        public List<Room> GetAll()
        {
            ReadJson();
            return rooms;
        }

        public List<Room> GetAllRoomsByEquipment(String name)
        {
            ReadJson();

            foreach (var temp in eq)
            {
                if (temp.Name == name)
                {
                     var temp1 = rooms.Find(obj => obj.Id == temp.RoomId);
                     rooms.Add(temp1);
                }
            }
            return rooms;
        }
        /*
      public Model.Room Read()
      {
         // TODO: implement
         return null;
      }
      
      public List<Room> GetAll()
      {
         // TODO: implement
         return null;
      }
      
      public void Create(int newNumber, Model.RoomType newType, int newFlore, String newDescription)
      {
         // TODO: implement
      }
      
      public void Delete(int number)
      {
         // TODO: implement
      }
      
      public int getAllFromStorage__()
      {
         // TODO: implement
         return 0;
      }*/

    }
}