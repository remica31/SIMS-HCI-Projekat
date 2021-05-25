/***********************************************************************
 * Module:  Patient.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Patient
 ***********************************************************************/

using Model;
using Repository;
using System; using System.Collections.Generic;


namespace Service
{
   public class HospitalTreatmentService
   {
        public HospitalTreatmentRepository hospitalTreatmentRepository = new HospitalTreatmentRepository();


        public List<HospitalTReatment> GetAll()
        {
            return hospitalTreatmentRepository.GetAll();
        }

       

        public void Save(HospitalTReatment hospitalTreatment)
        {
            hospitalTreatmentRepository.Save(hospitalTreatment);


        }

        public void Delete(int id)
        {
            hospitalTreatmentRepository.Delete(id);
        }

        public void Update(HospitalTReatment hospitalTreatment)
        {
            hospitalTreatmentRepository.Update(hospitalTreatment);

        }
        public HospitalTReatment GetById(int id)
        {
            return hospitalTreatmentRepository.GetById(id);
        }
        public void Extend(int id, int moreDays)
        {
            HospitalTReatment hospitalTReatment = hospitalTreatmentRepository.GetById(id);
            hospitalTReatment.FinishTime = hospitalTReatment.FinishTime.AddDays(moreDays);
            hospitalTreatmentRepository.Update(hospitalTReatment);
        }

    }
}