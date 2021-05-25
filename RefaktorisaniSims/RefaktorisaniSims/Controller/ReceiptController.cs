/***********************************************************************
 * Module:  Receipt.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.Receipt
 ***********************************************************************/

using Model;
using Service;
using System; using System.Collections.Generic;

namespace Controller
{
   public class ReceiptController
   {

        private ReceiptService receiptService = new ReceiptService();

        public List<Receipt> GetAll()
        {
            return receiptService.GetAll();
        }

        public Receipt GetById(string id)
        {
            return receiptService.GetById(id);
        }

        public void Save(Receipt receipt)
        {
            receiptService.Save(receipt);
        }

        public void Delete(string id)
        {
            receiptService.Delete(id);
        }

        public void Update(Receipt receipt)
        {
            receiptService.Update(receipt);
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