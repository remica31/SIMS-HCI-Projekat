/***********************************************************************
 * Module:  MedicineNotification.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.MedicineNotification
 ***********************************************************************/

using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class MedicineNotification
   {
      public  MedicineNotification()
        {
            Id = "1";
            StartDate = new DateTime(2021, 5, 5);
            FinishDate = new DateTime(2021, 5, 15);
            Description = "Razmuti u vodi i popij";
            StepInHours = 12;

        }
      public String Id { get; set; }
      public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public String Description { get; set; }
        public int StepInHours { get; set; }

        public Medicine medicine { get; set; }
        public Patient patient { get; set; }

    }
}