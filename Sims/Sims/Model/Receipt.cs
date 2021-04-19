/***********************************************************************
 * Module:  Receipt.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.Receipt
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;

namespace Model
{
   public class Receipt
   {
      public void Create(String newId, String description, int quantity, String medicineId)
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
   
      public String Id;
      public String Description;
      public int Quantity;
      public List<Medicine> Medicines;
      
      public System.Collections.ArrayList medicine;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetMedicine()
      {
         if (medicine == null)
            medicine = new System.Collections.ArrayList();
         return medicine;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetMedicine(System.Collections.ArrayList newMedicine)
      {
         RemoveAllMedicine();
         foreach (Medicine oMedicine in newMedicine)
            AddMedicine(oMedicine);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddMedicine(Medicine newMedicine)
      {
         if (newMedicine == null)
            return;
         if (this.medicine == null)
            this.medicine = new System.Collections.ArrayList();
         if (!this.medicine.Contains(newMedicine))
            this.medicine.Add(newMedicine);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveMedicine(Medicine oldMedicine)
      {
         if (oldMedicine == null)
            return;
         if (this.medicine != null)
            if (this.medicine.Contains(oldMedicine))
               this.medicine.Remove(oldMedicine);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllMedicine()
      {
         if (medicine != null)
            medicine.Clear();
      }
   
   }
}