/***********************************************************************
 * Module:  Order.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.Order
 ***********************************************************************/

using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class Order
   {
      public String Id;
      public String DynamicEquipmentName;
      public int Quantity;
      public OrderStatus Status;
      public DateTime Date;
      
      public System.Collections.ArrayList dynamicEquipmentRequest;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetDynamicEquipmentRequest()
      {
         if (dynamicEquipmentRequest == null)
            dynamicEquipmentRequest = new System.Collections.ArrayList();
         return dynamicEquipmentRequest;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetDynamicEquipmentRequest(System.Collections.ArrayList newDynamicEquipmentRequest)
      {
         RemoveAllDynamicEquipmentRequest();
         foreach (DynamicEquipmentRequest oDynamicEquipmentRequest in newDynamicEquipmentRequest)
            AddDynamicEquipmentRequest(oDynamicEquipmentRequest);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddDynamicEquipmentRequest(DynamicEquipmentRequest newDynamicEquipmentRequest)
      {
         if (newDynamicEquipmentRequest == null)
            return;
         if (this.dynamicEquipmentRequest == null)
            this.dynamicEquipmentRequest = new System.Collections.ArrayList();
         if (!this.dynamicEquipmentRequest.Contains(newDynamicEquipmentRequest))
            this.dynamicEquipmentRequest.Add(newDynamicEquipmentRequest);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveDynamicEquipmentRequest(DynamicEquipmentRequest oldDynamicEquipmentRequest)
      {
         if (oldDynamicEquipmentRequest == null)
            return;
         if (this.dynamicEquipmentRequest != null)
            if (this.dynamicEquipmentRequest.Contains(oldDynamicEquipmentRequest))
               this.dynamicEquipmentRequest.Remove(oldDynamicEquipmentRequest);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllDynamicEquipmentRequest()
      {
         if (dynamicEquipmentRequest != null)
            dynamicEquipmentRequest.Clear();
      }
   
   }
}