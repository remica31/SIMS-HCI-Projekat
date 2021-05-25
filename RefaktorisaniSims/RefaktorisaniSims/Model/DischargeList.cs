/***********************************************************************
 * Module:  DischargeList.cs
 * Author:  vidak
 * Purpose: Definition of the Class Model.DischargeList
 ***********************************************************************/

using System;

namespace Model
{
    public class DischargeList
    {
        public DischargeList(string patientName, string patientSurname, DateTime end, string desc)
        {
            PatientName = patientName;
            PatientSurname = patientSurname;
            EndTime = end;
            Description = desc;
        }
        public string PatientName { get; set; }

        public string PatientSurname { get; set; }
        public DateTime EndTime { get; set; }
        public String Description { get; set; }

    }
}
