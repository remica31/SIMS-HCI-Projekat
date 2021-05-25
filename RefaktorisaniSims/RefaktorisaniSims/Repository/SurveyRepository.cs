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
<<<<<<< Updated upstream
=======
        private readonly string fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\RefaktorisaniSims\\Data\\surveys.json";//D:\Ovde radi sims\RefaktorisaniSims\RefaktorisaniSims\Data\surveys.json
        public List<Survey> surveys = new List<Survey>();

        public SurveyRepository()
        {
            ReadJson();
        }

        public void ReadJson()
        {
            if (!File.Exists(fileLocation))
            {
                File.Create(fileLocation).Close();
            }

            using (StreamReader r = new StreamReader(fileLocation))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    surveys = JsonConvert.DeserializeObject<List<Survey>>(json);
                }
            }
        }

        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(surveys);
            File.WriteAllText(fileLocation, json);
        }
        public void Save(Survey survey)
        {
            ReadJson();
            surveys.Add(survey);
            WriteToJson();
        }

        public void Delete(string id)
        {
            ReadJson();

            int index = surveys.FindIndex(obj => obj.Id == id);
            surveys.RemoveAt(index);
            WriteToJson();
        }

        public void Update(Survey survey)
        {
            ReadJson();
            int index = surveys.FindIndex(obj => obj.Id == survey.Id);
            surveys[index] = survey;
            WriteToJson();
        }
        public Survey GetById(String id)
        {
            // TODO: implement
            ReadJson();
            return surveys.Find(obj => obj.Id == id);
        }
        public List<Survey> GetAll()
        {
            ReadJson();
            return surveys;
        }

        public double CountAverageHospitalRate()
        {
            double sum = 0;
            double counter = 0;
            foreach (var s in surveys)
            {
                if (s.RateFor != "doctor")
                {
                    sum += s.RateForHospital;
                    counter++;
                }
            }
            return sum / counter;
        }

        public double CountAverageDoctorRate(string id)
        {
            double sum = 0;
            double counter = 0;
            foreach (var s in surveys)
            {
                if (s.RateFor != "hospital" && s.DoctorId == id)
                {
                    sum += s.RateForDoctor;
                    counter++;
                }
            }
            return sum / counter;
        }

        public int CountRatesForHospital(int rate)
        {
            int numOfRates = 0;
            foreach (var s in surveys)
            {
                if (s.RateFor != "doctor" && s.RateForHospital == rate)
                {
                    numOfRates++;
                }
            }
            return numOfRates;
        }

        public int CountRatesForDoctor(string id, int rate)
        {
            int numOfRates = 0;
            foreach (var s in surveys)
            {
                if (s.DoctorId == id && s.RateFor != "hospital" && s.RateForDoctor == rate)
                {
                    numOfRates++;
                }
            }
            return numOfRates;
        }

        


        /*
>>>>>>> Stashed changes
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