using RefaktorisaniSims.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;



namespace RefaktorisaniSims.Controller
{
     public class PatientNoteController
    {

        

        private PatientNoteService patientNoteService = new PatientNoteService();


        public List<PatientNotes> GetAll()
        {
            return patientNoteService.GetAll();
        }

        public PatientNotes GetById(String id)
        {
            return patientNoteService.GetById(id);
        }

        public void Save(PatientNotes receipt)
        {
            patientNoteService.Save(receipt);
        }

        public void Delete(string id)
        {
            patientNoteService.Delete(id);
        }

        public void Update(PatientNotes receipt)
        {
            patientNoteService.Update(receipt);
        }
    }
}
