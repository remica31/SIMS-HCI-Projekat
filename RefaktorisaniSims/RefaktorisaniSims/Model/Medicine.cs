/***********************************************************************
 * Module:  Medicine.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.Medicine
 ***********************************************************************/

using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class Medicine
   {
        public Medicine()
        {
            Id = "3";
            Name = "Anadol";
            Description = "Opis3";
            Status = "Accepted";
            DoctorComment = "/";
            Ingredients = "Sastojci2";
        }
      public String Id { set; get; }
      public String Name { set; get; }
        public String Description { set; get; }
        public String Status { set; get; }
        public String DoctorComment { set; get; }
        public String Ingredients { set; get; }

    }
}