/***********************************************************************
 * Module:  Warden.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Warden
 ***********************************************************************/

using System;

namespace Model
{
   public class Warden
   {
      public User user;
      public Werehouse werehouse;
      public System.Collections.ArrayList holidayRequest;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetHolidayRequest()
      {
         if (holidayRequest == null)
            holidayRequest = new System.Collections.ArrayList();
         return holidayRequest;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetHolidayRequest(System.Collections.ArrayList newHolidayRequest)
      {
         RemoveAllHolidayRequest();
         foreach (HolidayRequest oHolidayRequest in newHolidayRequest)
            AddHolidayRequest(oHolidayRequest);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddHolidayRequest(HolidayRequest newHolidayRequest)
      {
         if (newHolidayRequest == null)
            return;
         if (this.holidayRequest == null)
            this.holidayRequest = new System.Collections.ArrayList();
         if (!this.holidayRequest.Contains(newHolidayRequest))
            this.holidayRequest.Add(newHolidayRequest);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveHolidayRequest(HolidayRequest oldHolidayRequest)
      {
         if (oldHolidayRequest == null)
            return;
         if (this.holidayRequest != null)
            if (this.holidayRequest.Contains(oldHolidayRequest))
               this.holidayRequest.Remove(oldHolidayRequest);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllHolidayRequest()
      {
         if (holidayRequest != null)
            holidayRequest.Clear();
      }
      public System.Collections.ArrayList dinamicEquipmentRequest;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetDinamicEquipmentRequest()
      {
         if (dinamicEquipmentRequest == null)
            dinamicEquipmentRequest = new System.Collections.ArrayList();
         return dinamicEquipmentRequest;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetDinamicEquipmentRequest(System.Collections.ArrayList newDinamicEquipmentRequest)
      {
         RemoveAllDinamicEquipmentRequest();
         foreach (DinamicEquipmentRequest oDinamicEquipmentRequest in newDinamicEquipmentRequest)
            AddDinamicEquipmentRequest(oDinamicEquipmentRequest);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddDinamicEquipmentRequest(DinamicEquipmentRequest newDinamicEquipmentRequest)
      {
         if (newDinamicEquipmentRequest == null)
            return;
         if (this.dinamicEquipmentRequest == null)
            this.dinamicEquipmentRequest = new System.Collections.ArrayList();
         if (!this.dinamicEquipmentRequest.Contains(newDinamicEquipmentRequest))
            this.dinamicEquipmentRequest.Add(newDinamicEquipmentRequest);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveDinamicEquipmentRequest(DinamicEquipmentRequest oldDinamicEquipmentRequest)
      {
         if (oldDinamicEquipmentRequest == null)
            return;
         if (this.dinamicEquipmentRequest != null)
            if (this.dinamicEquipmentRequest.Contains(oldDinamicEquipmentRequest))
               this.dinamicEquipmentRequest.Remove(oldDinamicEquipmentRequest);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllDinamicEquipmentRequest()
      {
         if (dinamicEquipmentRequest != null)
            dinamicEquipmentRequest.Clear();
      }
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