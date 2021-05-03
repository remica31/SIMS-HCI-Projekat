// File:    Allergen.cs
// Author:  LENOVO
// Created: Friday, April 9, 2021 20:59:39
// Purpose: Definition of Class Allergen

using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class Allergen
   {
        public Allergen(string id, string name, string description, string patientId)
        {
            Id = id;
            Name = name;
            Description = description;
            PatientId = patientId;
        }
      public String Id { get; set; }
      public String Name { get; set; }
      public String Description { get; set; }

      public String PatientId { get; set; }
   
   }
}