using RefaktorisaniSims.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace RefaktorisaniSims.Service
{
    class PatientNoteService
    {

        private PatientNoteRepository patientNoteRepository = new PatientNoteRepository();


        public List<PatientNotes> GetAll()
        {
            return patientNoteRepository.GetAll();
        }

        public PatientNotes GetById(String id)
        {
            return patientNoteRepository.GetById(id);
        }

        public void Save(PatientNotes patientNote)
        {
            patientNoteRepository.Save(patientNote);


        }

        public void Delete(String id)
        {
            patientNoteRepository.Delete(id);
        }

        public void Update(PatientNotes patientNote)
        {
            patientNoteRepository.Update(patientNote);

        }
    }
}
