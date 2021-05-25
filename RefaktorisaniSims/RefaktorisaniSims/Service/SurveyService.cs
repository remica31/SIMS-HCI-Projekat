/***********************************************************************
 * Module:  Survey.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.Survey
 ***********************************************************************/

using Model;
using Repository;
using System; using System.Collections.Generic;


namespace Service
{
   public class SurveyService
   {
        public SurveyRepository surveyRepository = new SurveyRepository();


        public List<Survey> GetAll()
        {
            return surveyRepository.GetAll();
        }

        public Survey GetById(string id)
        {
            return surveyRepository.GetById(id);
        }

        public void Save(Survey survey)
        {
            surveyRepository.Save(survey);


        }

        public void Delete(string id)
        {
            surveyRepository.Delete(id);
        }

        public void Update(Survey survey)
        {
            surveyRepository.Update(survey);

        }

        public double CountAverageHospitalRate()
        {
            return surveyRepository.CountAverageHospitalRate();
        }

        public double CountAverageDoctorRate(string id)
        {
            return surveyRepository.CountAverageDoctorRate(id);
        }

        public int CountHospitalRates(int rate)
        {
            return surveyRepository.CountRatesForHospital(rate);
        }

        public int CountDoctorRates(string id, int rate)
        {
            return surveyRepository.CountRatesForDoctor(id, rate);
        }
        /*
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
   
     
   */
    }
}