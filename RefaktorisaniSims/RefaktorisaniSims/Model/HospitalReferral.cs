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
      public String Id;
      public String PatientId;
      public String FromDoctorId;
      public String ToDoctorId;
      public String Explanation;
      
      public Doctor doctor;
      public Patient patient;
   
   }
}