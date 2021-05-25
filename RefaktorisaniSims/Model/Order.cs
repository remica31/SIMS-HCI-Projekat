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
      public String Id { get; set; }
      public String DynamicEquipmentName { get; set; }
      public int Quantity { get; set; }
      public String Status { get; set; }
      public DateTime Date { get; set; }

      public Order(string id, string name, int quantity, string status, DateTime date)
        {
            Id = id;
            DynamicEquipmentName = name;
            Quantity = quantity;
            Status = status;
            Date = date;
        }
      
      public System.Collections.ArrayList dynamicEquipmentRequest { get; set; }
      
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