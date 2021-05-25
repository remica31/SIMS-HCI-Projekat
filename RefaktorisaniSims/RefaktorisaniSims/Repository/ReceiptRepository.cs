/***********************************************************************
 * Module:  Receipt.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.Receipt
 ***********************************************************************/

using Model;
using Newtonsoft.Json;
using System; using System.Collections.Generic;
using System.IO;

namespace Repository
{
   public class ReceiptRepository
   {


        private readonly string fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\RefaktorisaniSims\\Data\\receipts.json";//D:\Ovde radi sims\RefaktorisaniSims\RefaktorisaniSims\Data\receipts.json
        public List<Receipt> receipts = new List<Receipt>();

        public ReceiptRepository()
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
                    receipts = JsonConvert.DeserializeObject<List<Receipt>>(json);
                }
            }
        }

        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(receipts);
            File.WriteAllText(fileLocation, json);
        }
        public void Save(Receipt receipt)
        {
            ReadJson();
            receipts.Add(receipt);
            WriteToJson();
        }

        public void Delete(string id)
        {
            ReadJson();

            int index = receipts.FindIndex(obj => obj.Id == id);
            receipts.RemoveAt(index);
            WriteToJson();
        }

        public void Update(Receipt receipt)
        {
            ReadJson();
            int index = receipts.FindIndex(obj => obj.Id == receipt.Id);
            receipts[index] = receipt;
            WriteToJson();
        }
        public Receipt GetById(String id)
        {
            // TODO: implement
            ReadJson();
            return receipts.Find(obj => obj.Id == id);
        }
        public List<Receipt> GetAll()
        {
            ReadJson();
            return receipts;
        }
        /*
      public void Create(String newId, String description, int quantity, String receiptId)
      {
         // TODO: implement
      }
      
      public void Delete(String id)
      {
         // TODO: implement
      }
      
      public List<Receipt> ReadAll()
      {
         // TODO: implement
         return null;
      }
      
      public Receipt Read(String id)
      {
         // TODO: implement
         return null;
      }
   */
    }
}