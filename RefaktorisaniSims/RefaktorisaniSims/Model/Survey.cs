/***********************************************************************
 * Module:  Survey.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.Survey
 ***********************************************************************/

using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class Survey
   {
        public Survey()
        {

        }
        public Survey(string id, string patientId, string doctorId,int rateH, int rateD)
        {
            Id = id;
            patientId = PatientId;
            DoctorId = doctorId;
            RateForHospital = rateH;
            RateForDoctor = rateD;
        }
      public String Id { set; get; }
      public String PatientId { set; get; }
        public String DoctorId { set; get; }
        public int RateForHospital { set; get; }
        public int RateForDoctor { set; get; }

    }
}