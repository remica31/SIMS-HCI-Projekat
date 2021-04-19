/***********************************************************************
 * Module:  Werehouse.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.Werehouse
 ***********************************************************************/

using System;

namespace Model
{
   public class Werehouse
   {
      public String Id;
      public String Name;
      
      public DinamicEquipments[] dinamicEquipments;
      public System.Collections.ArrayList staticEquipments;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetStaticEquipments()
      {
         if (staticEquipments == null)
            staticEquipments = new System.Collections.ArrayList();
         return staticEquipments;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetStaticEquipments(System.Collections.ArrayList newStaticEquipments)
      {
         RemoveAllStaticEquipments();
         foreach (StaticEquipments oStaticEquipments in newStaticEquipments)
            AddStaticEquipments(oStaticEquipments);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddStaticEquipments(StaticEquipments newStaticEquipments)
      {
         if (newStaticEquipments == null)
            return;
         if (this.staticEquipments == null)
            this.staticEquipments = new System.Collections.ArrayList();
         if (!this.staticEquipments.Contains(newStaticEquipments))
            this.staticEquipments.Add(newStaticEquipments);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveStaticEquipments(StaticEquipments oldStaticEquipments)
      {
         if (oldStaticEquipments == null)
            return;
         if (this.staticEquipments != null)
            if (this.staticEquipments.Contains(oldStaticEquipments))
               this.staticEquipments.Remove(oldStaticEquipments);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllStaticEquipments()
      {
         if (staticEquipments != null)
            staticEquipments.Clear();
      }
   
   }
}