/***********************************************************************
 * Module:  Request.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Request
 ***********************************************************************/

using Model;
using Newtonsoft.Json;
using System; using System.Collections.Generic;
using System.IO;

namespace Repository
{
   public class HolidayRequestRepository
    {
        private readonly string fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\RefaktorisaniSims\\Data\\holidayRequests.json";
        public List<HolidayRequest> requests = new List<HolidayRequest>();

        public HolidayRequestRepository()
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
                    requests = JsonConvert.DeserializeObject<List<HolidayRequest>>(json);
                }
            }
        }

        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(requests);
            File.WriteAllText(fileLocation, json);
        }

        public void Save(HolidayRequest hr)
        {
            ReadJson();
            requests.Add(hr);
            WriteToJson();
        }

        public void Delete(string id)
        {
            ReadJson();

            int index = requests.FindIndex(obj => obj.Id == id);
            requests.RemoveAt(index);
            WriteToJson();
        }

        public void Update(HolidayRequest hr)
        {
            ReadJson();
            int index = requests.FindIndex(obj => obj.Id == hr.Id);
            requests[index] = hr;
            WriteToJson();
        }
        public HolidayRequest GetById(String id)
        {
            // TODO: implement
            ReadJson();
            return requests.Find(obj => obj.Id == id);
        }
        public List<HolidayRequest> GetAll()
        {
            ReadJson();
            return requests;
        }

        /*
        public void Create(String newId, String newDescription, DateTime newSubmissionDate, int newDurationinDays, DateTime newStartDate)
          {
             // TODO: implement
          }
      
          public void Update(String newDescription, int newDurationInDays, DateTime newStardDate)
          {
             // TODO: implement
          }
      
          public void Delete(String id)
          {
             // TODO: implement
          }
      
          public HolidayRequest Read(String id)
          {
             // TODO: implement
             return null;
          }
      
          public List<HolidayRequest> ReadAll()
          {
             // TODO: implement
             return null;
          }
      
          public Model.StatusType UpdateStatus(Model.StatusType newStatus)
          {
             // TODO: implement
             return null;
          }*/

    }
}