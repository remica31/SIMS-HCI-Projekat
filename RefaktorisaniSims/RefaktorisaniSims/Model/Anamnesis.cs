// File:    Allergen.cs
// Author:  LENOVO
// Created: Friday, April 9, 2021 20:59:39
// Purpose: Definition of Class Allergen

using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class Anamnesis
   {
        public Anamnesis() { }
        public Anamnesis(string id, string name, string description, DateTime date, string patientid)
        {
            Id = id;
            Name = name;
            Description = description;
            Date = date;
            PatientId = patientid;
        }
        
      public String Id { get; set; }
      public String Name { get; set; }
        public String Description { get; set; }
        public DateTime Date { get; set; }

        public String PatientId { get; set; }
       // public String DoctorId { get; set; }
    }
}