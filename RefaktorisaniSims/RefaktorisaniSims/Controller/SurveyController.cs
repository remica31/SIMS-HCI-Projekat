/***********************************************************************
 * Module:  Survey.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.Survey
 ***********************************************************************/

using Model;
using Service;
using System; using System.Collections.Generic;


namespace Controller
{
   public class SurveyController
   {
        private SurveyService surveyService = new SurveyService();

        public List<Survey> GetAll()
        {
            return surveyService.GetAll();
        }

        public Survey GetById(string id)
        {
            return surveyService.GetById(id);
        }

        public void Save(Survey survey)
        {
            surveyService.Save(survey);
        }

        public void Delete(string id)
        {
            surveyService.Delete(id);
        }

        public void Update(Survey survey)
        {
            surveyService.Update(survey);
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
   
      public System.Collections.ArrayList surveyService;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetSurveyService()
      {
         if (surveyService == null)
            surveyService = new System.Collections.ArrayList();
         return surveyService;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetSurveyService(System.Collections.ArrayList newSurveyService)
      {
         RemoveAllSurveyService();
         foreach (SurveyService oSurveyService in newSurveyService)
            AddSurveyService(oSurveyService);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddSurveyService(SurveyService newSurveyService)
      {
         if (newSurveyService == null)
            return;
         if (this.surveyService == null)
            this.surveyService = new System.Collections.ArrayList();
         if (!this.surveyService.Contains(newSurveyService))
            this.surveyService.Add(newSurveyService);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveSurveyService(SurveyService oldSurveyService)
      {
         if (oldSurveyService == null)
            return;
         if (this.surveyService != null)
            if (this.surveyService.Contains(oldSurveyService))
               this.surveyService.Remove(oldSurveyService);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllSurveyService()
      {
         if (surveyService != null)
            surveyService.Clear();
      }
   */
    }
}