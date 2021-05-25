/***********************************************************************
 * Module:  Receipt.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.Receipt
 ***********************************************************************/

using Model;
using Repository;
using System; using System.Collections.Generic;

namespace Service
{
   public class ReceiptService
   {
        public ReceiptRepository receiptRepository = new ReceiptRepository();


        public List<Receipt> GetAll()
        {
            return receiptRepository.GetAll();
        }

        public Receipt GetById(string id)
        {
            return receiptRepository.GetById(id);
        }

        public void Save(Receipt receipt)
        {
            receiptRepository.Save(receipt);


        }

        public void Delete(string id)
        {
            receiptRepository.Delete(id);
        }

        public void Update(Receipt receipt)
        {
            receiptRepository.Update(receipt);

        }
    }
}