/***********************************************************************
 * Module:  StorageAppoitmentDoctor.cs
 * Author:  Vujke
 * Purpose: Definition of the Class StorageAppoitmentDoctor
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Model
{
   public class FileStorageDoctor
   {
      public string FileLocation;
        public FileStorageDoctor()
        {
            requests = new List<DinamicEquipmentRequest>();
        }
        public List<DinamicEquipmentRequest> requests;
        public List<DinamicEquipmentRequest> GetAll()
        {
            return requests;
        }

        public void ReadRequests()
        {
            requests = new List<DinamicEquipmentRequest>();
            string filePath = @"C:\Users\Remica\Desktop\rema\Sims\Sims\Data\dynamicreq.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (var line in lines)
            {
                var newRequest = new DinamicEquipmentRequest();

                string[] entries = line.Split(',');

                newRequest.Id = entries[0];
                newRequest.Name = entries[1];
                newRequest.Date = entries[2];
                newRequest.StatusType = entries[3]; 
                requests.Add(newRequest);

            }
        }

        public void createRequest(string id, string name)
        {
            string filePath1 = @"C:\Users\Remica\Desktop\rema\Sims\Sims\Data\dynamicreq.txt";
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath1).ToList();

            string newLine = id + ", " + name + ", " + "datum" + "," + "WAITING";
            lines.Add(newLine);
            File.WriteAllLines(filePath1, lines);
        }

        public void updateRequest(string id, string newName)
        {
            foreach (var req in requests)

            {
                if (req.Id == id)
                {
                    req.Name = newName;
                }
            }

        }

        public void deleteRequest(string id)
        {
            List<DinamicEquipmentRequest> newRequests = new List<DinamicEquipmentRequest>();
            foreach (var req in requests)
            {
                if (req.Id != id)
                {
                    newRequests.Add(req);
                }
            }
            requests = newRequests;
        }

        public void write()
        {
            string filePath1 = @"C:\Users\Remica\Desktop\rema\Sims\Sims\Data\dynamicreq.txt";
            List<string> lines = new List<string>();
            foreach (var req in requests)
            {
                string id = Convert.ToString(req.Id);//"A1";
                string name = Convert.ToString(req.Name);//"12";
                string date = Convert.ToString(req.Date);//"1";
                string status = req.StatusType.ToString();
                string s10 = id + "," + name + "," + date + "," + status;
                lines.Add(s10);
            }
            File.WriteAllLines(filePath1, lines);
        }

    }

    

}