/***********************************************************************
 * Module:  Guest.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.Guest
 ***********************************************************************/

using Model;
using Newtonsoft.Json;
using System; using System.Collections.Generic;
using System.IO;

namespace Repository
{
   public class GuestRepository
   {
        private readonly string fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\RefaktorisaniSims\\Data\\guests.json";//D:\Ovde radi sims\RefaktorisaniSims\RefaktorisaniSims\Data\guests.json
        public List<Guest> guests = new List<Guest>();

        public GuestRepository()
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
                    guests = JsonConvert.DeserializeObject<List<Guest>>(json);
                }
            }
        }

        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(guests);
            File.WriteAllText(fileLocation, json);
        }
        public void Save(Guest guest)
        {
            ReadJson();
            guests.Add(guest);
            WriteToJson();
        }
        public Guest GetById(String id)
        {
            // TODO: implement
            ReadJson();
            return guests.Find(obj => obj.Id == id);
        }
        /*
      public void Create(String jmbg, String newName, String newSurname, String newUsername, String newPassword)
      {
         // TODO: implement
      }
   */
    }
}