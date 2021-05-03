/***********************************************************************
 * Module:  Survey.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.Survey
 ***********************************************************************/


using Model; using System; using System.Collections.Generic;


namespace Repository
{
   public class SurveyRepository
   {
      public void Create(String id, String patientId, String doctorId, int rateForHospital, int rateForDoctor)
      {
         // TODO: implement
      }
      
      public List<Survey> ReadAll()
      {
         // TODO: implement
         return null;
      }
      
      public List<Survey> GetAllByDoctorId(String id)
      {
         // TODO: implement
         return null;
      }
   
   }
}