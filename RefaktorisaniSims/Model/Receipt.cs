/***********************************************************************
 * Module:  Receipt.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.Receipt
 ***********************************************************************/

using Model; using System; using System.Collections.Generic;

namespace Model
{
    public class Receipt
    {
        public Receipt() 
        {
            Medicines = new List<Medicine>();
        }
        public Receipt(string receipeID, string patientID, string newInstruction, int newQuantity, string doctorID)
        {
            Medicines = new List<Medicine>();
            Id = receipeID;
            Instructions = newInstruction;
            this.PatientID = patientID;
            this.DoctorID = doctorID;
            Quantity = newQuantity;
            
        }
        public String Id { set; get; }
        public String Instructions { set; get; }
        public int Quantity { set; get; }
        public List<Medicine> Medicines { set; get; }

        
        public String PatientID { set; get; }

        public String DoctorID { set; get; }
      
   }
}