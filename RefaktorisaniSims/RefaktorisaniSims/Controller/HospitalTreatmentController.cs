/***********************************************************************
 * Module:  Patient.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Patient
 ***********************************************************************/

using Model;
using Service;
using System; using System.Collections.Generic;


namespace Controller
{
   public class HospitalTreatmentController
   {
        private HospitalTreatmentService hospitalTReatmentService = new HospitalTreatmentService();

        public List<HospitalTReatment> GetAll()
        {
            return hospitalTReatmentService.GetAll();
        }

       
        public void Save(HospitalTReatment hospitalTReatment)
        {
            hospitalTReatmentService.Save(hospitalTReatment);
        }

        public void Delete(int id)
        {
            hospitalTReatmentService.Delete(id);
        }

        public void Update(HospitalTReatment hospitalTReatment)
        {
            hospitalTReatmentService.Update(hospitalTReatment);
        }

        public HospitalTReatment GetById(int id)
        {
            return hospitalTReatmentService.GetById(id);
        }
        public void Extend(int id, int moreDays)
        {
            hospitalTReatmentService.Extend(id, moreDays);
        }
   }
}