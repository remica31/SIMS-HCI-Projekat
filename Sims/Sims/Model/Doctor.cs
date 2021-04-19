/***********************************************************************
 * Module:  Doctor.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Doctor
 ***********************************************************************/

using System;

namespace Model
{
   public class Doctor
   {
      public String SpecializationType;
      
      public HolidayRequest[] holidayRequest;
      public User user;
      public Room room;
      public System.Collections.ArrayList operations;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetOperations()
      {
         if (operations == null)
            operations = new System.Collections.ArrayList();
         return operations;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetOperations(System.Collections.ArrayList newOperations)
      {
         RemoveAllOperations();
         foreach (Operations oOperations in newOperations)
            AddOperations(oOperations);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddOperations(Operations newOperations)
      {
         if (newOperations == null)
            return;
         if (this.operations == null)
            this.operations = new System.Collections.ArrayList();
         if (!this.operations.Contains(newOperations))
            this.operations.Add(newOperations);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveOperations(Operations oldOperations)
      {
         if (oldOperations == null)
            return;
         if (this.operations != null)
            if (this.operations.Contains(oldOperations))
               this.operations.Remove(oldOperations);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllOperations()
      {
         if (operations != null)
            operations.Clear();
      }
      public System.Collections.ArrayList medicalRecord;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetMedicalRecord()
      {
         if (medicalRecord == null)
            medicalRecord = new System.Collections.ArrayList();
         return medicalRecord;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetMedicalRecord(System.Collections.ArrayList newMedicalRecord)
      {
         RemoveAllMedicalRecord();
         foreach (MedicalRecord oMedicalRecord in newMedicalRecord)
            AddMedicalRecord(oMedicalRecord);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddMedicalRecord(MedicalRecord newMedicalRecord)
      {
         if (newMedicalRecord == null)
            return;
         if (this.medicalRecord == null)
            this.medicalRecord = new System.Collections.ArrayList();
         if (!this.medicalRecord.Contains(newMedicalRecord))
            this.medicalRecord.Add(newMedicalRecord);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveMedicalRecord(MedicalRecord oldMedicalRecord)
      {
         if (oldMedicalRecord == null)
            return;
         if (this.medicalRecord != null)
            if (this.medicalRecord.Contains(oldMedicalRecord))
               this.medicalRecord.Remove(oldMedicalRecord);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllMedicalRecord()
      {
         if (medicalRecord != null)
            medicalRecord.Clear();
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
      public Appointment[] appointment;
   
   }
}