using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace RefaktorisaniSims.Repository
{
    class PatientNoteRepository
    {

        private readonly string fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\RefaktorisaniSims\\Data\\patientNotes.json";//D:\Ovde radi sims\RefaktorisaniSims\RefaktorisaniSims\Data\receipts.json
        public List<PatientNotes> patientNotes = new List<PatientNotes>();

        public PatientNoteRepository()
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
                    patientNotes = JsonConvert.DeserializeObject<List<PatientNotes>>(json);
                }
            }
        }

        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(patientNotes);
            File.WriteAllText(fileLocation, json);
        }
        public void Save(PatientNotes patientNote)
        {
            ReadJson();
            patientNotes.Add(patientNote);
            WriteToJson();
        }

        public void Delete(String id)
        {
            ReadJson();

            int index = patientNotes.FindIndex(obj => obj.Id == id);
            patientNotes.RemoveAt(index);
            WriteToJson();
        }

        public void Update(PatientNotes note)
        {
            ReadJson();
            int index = patientNotes.FindIndex(obj => obj.Id == note.Id);
            patientNotes[index] = note;
            WriteToJson();
        }
        public PatientNotes GetById(String id)
        {
            // TODO: implement
            ReadJson();
            return patientNotes.Find(obj => obj.Id == id);
        }
        public List<PatientNotes> GetAll()
        {
            ReadJson();
            return patientNotes;
        }
    }
}
