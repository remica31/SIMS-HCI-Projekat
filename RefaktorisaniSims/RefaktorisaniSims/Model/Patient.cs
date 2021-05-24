/***********************************************************************
 * Module:  Patient.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Patient
 ***********************************************************************/

using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class Patient
   {
        public Patient()
        {
        }
        public Patient(User user)
        {
            this.User = user;
        }
        public Patient(Guest guest)
        {
            var user = new User();
            user.Id = guest.Id;
            user.Name = guest.Name;
            user.Surname = guest.Surname;
            user.Username = guest.Username;
            user.Password = guest.Password;
            this.User = user;
        }
        /*
      public System.Collections.ArrayList survey;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetSurvey()
      {
         if (survey == null)
            survey = new System.Collections.ArrayList();
         return survey;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetSurvey(System.Collections.ArrayList newSurvey)
      {
         RemoveAllSurvey();
         foreach (Survey oSurvey in newSurvey)
            AddSurvey(oSurvey);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddSurvey(Survey newSurvey)
      {
         if (newSurvey == null)
            return;
         if (this.survey == null)
            this.survey = new System.Collections.ArrayList();
         if (!this.survey.Contains(newSurvey))
            this.survey.Add(newSurvey);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveSurvey(Survey oldSurvey)
      {
         if (oldSurvey == null)
            return;
         if (this.survey != null)
            if (this.survey.Contains(oldSurvey))
               this.survey.Remove(oldSurvey);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllSurvey()
      {
         if (survey != null)
            survey.Clear();
      }*/
      public User User { get; set; }
      public MedicalRecord medicalRecord { get; set; }
      public List<Appointment> appointments { get; set; }
   
   }
}