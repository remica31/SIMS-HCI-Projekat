/***********************************************************************
 * Module:  Warden.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Warden
 ***********************************************************************/

using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class Warden
   {
      public User user;
      public System.Collections.ArrayList staticTransferSchedule;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetStaticTransferSchedule()
      {
         if (staticTransferSchedule == null)
            staticTransferSchedule = new System.Collections.ArrayList();
         return staticTransferSchedule;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetStaticTransferSchedule(System.Collections.ArrayList newStaticTransferSchedule)
      {
         RemoveAllStaticTransferSchedule();
         foreach (StaticTransferSchedule oStaticTransferSchedule in newStaticTransferSchedule)
            AddStaticTransferSchedule(oStaticTransferSchedule);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddStaticTransferSchedule(StaticTransferSchedule newStaticTransferSchedule)
      {
         if (newStaticTransferSchedule == null)
            return;
         if (this.staticTransferSchedule == null)
            this.staticTransferSchedule = new System.Collections.ArrayList();
         if (!this.staticTransferSchedule.Contains(newStaticTransferSchedule))
            this.staticTransferSchedule.Add(newStaticTransferSchedule);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveStaticTransferSchedule(StaticTransferSchedule oldStaticTransferSchedule)
      {
         if (oldStaticTransferSchedule == null)
            return;
         if (this.staticTransferSchedule != null)
            if (this.staticTransferSchedule.Contains(oldStaticTransferSchedule))
               this.staticTransferSchedule.Remove(oldStaticTransferSchedule);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllStaticTransferSchedule()
      {
         if (staticTransferSchedule != null)
            staticTransferSchedule.Clear();
      }
   
   }
}