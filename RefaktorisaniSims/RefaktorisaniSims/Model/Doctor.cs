/***********************************************************************
 * Module:  Doctor.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Doctor
 ***********************************************************************/

using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class Doctor
   {
        public Doctor()
        {
            /* this.User.Id = "d1";
             this.User.Name = "Mladen";
             this.User.Surname = "Pavlovic";
             this.User.Phone = "0692041119";
             this.User.Username = "Mlaki99";
             this.User.Password = "nekaSifra";
             this.User.EMail = "Mlakisa@gmail.com";
             this.User.Address = "NekaAdresa";
             this.User.DateOfBirth = new DateTime(1999, 4, 20);*/
          //  this.User = new User();
          //  this.SpecializationType = "Hirurg";
            
        }
        public Doctor(User user, string spec)
        {
            this.User = user;
            this.SpecializationType = spec;
        }
      public void Create(User user, String specializationtype)
      {
         // TODO: implement
      }
      
      public void Update()
      {
         // TODO: implement
      }
      
      public List<Doctor> GetAll()
      {
         // TODO: implement
         return null;
      }
      
      public Doctor GetById(String id)
      {
         // TODO: implement
         return null;
      }
   
      public String SpecializationType { get; set; }
      
      public HolidayRequest[] holidayRequest { get; set; }
        public User User { get; set; }
        public Room Room { get; set; }
        public List<Operation> operations;
        public List<Appointment> appointments;
      
        /*
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetOperation()
      {
         if (operation == null)
            operation = new System.Collections.ArrayList();
         return operation;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetOperation(System.Collections.ArrayList newOperation)
      {
         RemoveAllOperation();
         foreach (Operation oOperation in newOperation)
            AddOperation(oOperation);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddOperation(Operation newOperation)
      {
         if (newOperation == null)
            return;
         if (this.operation == null)
            this.operation = new System.Collections.ArrayList();
         if (!this.operation.Contains(newOperation))
            this.operation.Add(newOperation);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveOperation(Operation oldOperation)
      {
         if (oldOperation == null)
            return;
         if (this.operation != null)
            if (this.operation.Contains(oldOperation))
               this.operation.Remove(oldOperation);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllOperation()
      {
         if (operation != null)
            operation.Clear();
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
      */
   
   }
}