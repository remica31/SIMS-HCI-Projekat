/***********************************************************************
 * Module:  Operations.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.Operations
 ***********************************************************************/

using Model;
using Newtonsoft.Json;
using System; using System.Collections.Generic;
using System.IO;

namespace Repository
{
    
   public class OperationRepository
   {
        private readonly string fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\RefaktorisaniSims\\Data\\operations.json";//D:\Ovde radi sims\RefaktorisaniSims\RefaktorisaniSims\Data\operations.json
        public List<Operation> operations = new List<Operation>();

        public OperationRepository()
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
                    operations = JsonConvert.DeserializeObject<List<Operation>>(json);
                }
            }
        }

        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(operations);
            File.WriteAllText(fileLocation, json);
        }
        public void Save(Operation operation)
        {
            ReadJson();
            operations.Add(operation);
            WriteToJson();
        }

        public void Delete(string id)
        {
            ReadJson();

            int index = operations.FindIndex(obj => obj.Id == id);
            operations.RemoveAt(index);
            WriteToJson();
        }

        public void Update(Operation operation)
        {
            ReadJson();
            int index = operations.FindIndex(obj => obj.Id == operation.Id);
            operations[index] = operation;
            WriteToJson();
        }
        public Operation GetById(String id)
        {
            
            ReadJson();
            return operations.Find(obj => obj.Id == id);
        }
        public List<Operation> GetAll()
        {
            ReadJson();
            return operations;
        }
        public List<Operation> GetByDoctorId(string id)
        {
            List<Operation> ops = new List<Operation>();
            foreach(var op in operations)
            {
                if (op.doctor.User.Id == id)
                {
                    ops.Add(op);
                }
            }
            return ops;
        }
        /*
      public void Create(String newid, DateTime newStartTime, int newDuration, String newRoomId, String newfinishTime, Model.AppointmentType newOperationType)
      {
         // TODO: implement
      }
      
      public void Update(String id, DateTime startTime, int duration, String roomId, Model.AppointmentType appointmentType)
      {
         // TODO: implement
      }
      
      public void Delete(String id)
      {
         // TODO: implement
      }
      
      public List<Operation> GetAll()
      {
         // TODO: implement
         return null;
      }
      
      public Operation GetByid(String id)
      {
         // TODO: implement
         return null;
      }
   */
    }
}