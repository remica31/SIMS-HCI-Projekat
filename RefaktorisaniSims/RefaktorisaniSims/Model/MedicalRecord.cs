/***********************************************************************
 * Module:  MedicalRecord.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.MedicalRecord
 ***********************************************************************/

using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class MedicalRecord
   {
        public MedicalRecord()
        {

        }
      public String PatientId;
      public String Therapy;
        public List<Receipt> Receipts;
      public List<Allergen> allergens;
        public List<Anamnesis> anamneses;
      /*
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetAllergen()
      {
         if (allergen == null)
            allergen = new System.Collections.ArrayList();
         return allergen;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetAllergen(System.Collections.ArrayList newAllergen)
      {
         RemoveAllAllergen();
         foreach (Allergen oAllergen in newAllergen)
            AddAllergen(oAllergen);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddAllergen(Allergen newAllergen)
      {
         if (newAllergen == null)
            return;
         if (this.allergen == null)
            this.allergen = new System.Collections.ArrayList();
         if (!this.allergen.Contains(newAllergen))
            this.allergen.Add(newAllergen);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveAllergen(Allergen oldAllergen)
      {
         if (oldAllergen == null)
            return;
         if (this.allergen != null)
            if (this.allergen.Contains(oldAllergen))
               this.allergen.Remove(oldAllergen);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllAllergen()
      {
         if (allergen != null)
            allergen.Clear();
      }
      public System.Collections.ArrayList anamnesis;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetAnamnesis()
      {
         if (anamnesis == null)
            anamnesis = new System.Collections.ArrayList();
         return anamnesis;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetAnamnesis(System.Collections.ArrayList newAnamnesis)
      {
         RemoveAllAnamnesis();
         foreach (Anamnesis oAnamnesis in newAnamnesis)
            AddAnamnesis(oAnamnesis);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddAnamnesis(Anamnesis newAnamnesis)
      {
         if (newAnamnesis == null)
            return;
         if (this.anamnesis == null)
            this.anamnesis = new System.Collections.ArrayList();
         if (!this.anamnesis.Contains(newAnamnesis))
            this.anamnesis.Add(newAnamnesis);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveAnamnesis(Anamnesis oldAnamnesis)
      {
         if (oldAnamnesis == null)
            return;
         if (this.anamnesis != null)
            if (this.anamnesis.Contains(oldAnamnesis))
               this.anamnesis.Remove(oldAnamnesis);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllAnamnesis()
      {
         if (anamnesis != null)
            anamnesis.Clear();
      }
      public System.Collections.ArrayList receipt;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetReceipt()
      {
         if (receipt == null)
            receipt = new System.Collections.ArrayList();
         return receipt;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetReceipt(System.Collections.ArrayList newReceipt)
      {
         RemoveAllReceipt();
         foreach (Receipt oReceipt in newReceipt)
            AddReceipt(oReceipt);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddReceipt(Receipt newReceipt)
      {
         if (newReceipt == null)
            return;
         if (this.receipt == null)
            this.receipt = new System.Collections.ArrayList();
         if (!this.receipt.Contains(newReceipt))
            this.receipt.Add(newReceipt);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveReceipt(Receipt oldReceipt)
      {
         if (oldReceipt == null)
            return;
         if (this.receipt != null)
            if (this.receipt.Contains(oldReceipt))
               this.receipt.Remove(oldReceipt);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllReceipt()
      {
         if (receipt != null)
            receipt.Clear();
      }
   */
   }
}