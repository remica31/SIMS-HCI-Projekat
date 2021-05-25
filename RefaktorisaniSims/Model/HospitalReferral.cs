/***********************************************************************
 * Module:  HospitalReferral.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.HospitalReferral
 ***********************************************************************/

using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class HospitalReferral
   {
        public HospitalReferral() { }
        public HospitalReferral(string id, string fromDoctorId, string toDoctorId, string explanation, Patient patient)
        {
            this.Id = id;
            this.FromDoctorId = fromDoctorId;
            this.ToDoctorId = toDoctorId;
            this.Explanation = explanation;
            this.Patient = patient;
        }
      public String Id { set; get; }
        public String FromDoctorId { set; get; }
        public String ToDoctorId { set; get; }
        public String Explanation { set; get; }

        
        public Patient Patient { set; get; }

    }
}