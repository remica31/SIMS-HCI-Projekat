/***********************************************************************
 * Module:  HospitalTreatment.cs
 * Author:  vidak
 * Purpose: Definition of the Class Model.HospitalTreatment
 ***********************************************************************/

using System;

namespace Model
{
    public class HospitalTReatment
    {
        public HospitalTReatment() { }
        public HospitalTReatment(int id, DateTime d1, DateTime d2, string patient)
        {
            Id = id;
            StartTime = d1;
           
            FinishTime = d2;
            PatientID = patient;

        }
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }

        public String PatientID { get; set; }

    }
}
