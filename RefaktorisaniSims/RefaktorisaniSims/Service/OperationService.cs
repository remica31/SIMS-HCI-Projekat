/***********************************************************************
 * Module:  Operations.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.Operations
 ***********************************************************************/

using Model;
using Repository;
using System; using System.Collections.Generic;

namespace Service
{
   public class OperationService
   {

        public OperationRepository operationRepository = new OperationRepository();


        public List<Operation> GetAll()
        {
            return operationRepository.GetAll();
        }

        public Operation GetById(string id)
        {
            return operationRepository.GetById(id);
        }

        public void Save(Operation operation)
        {
            operationRepository.Save(operation);


        }

        public void Delete(string id)
        {
            operationRepository.Delete(id);
        }

        public void Update(Operation operation)
        {
            operationRepository.Update(operation);

        }
        public List<Operation> GetByDoctorId(string id)
        {
            return operationRepository.GetByDoctorId(id);
        }
        /*
      public void Create(String newid, DateTime newStartTime, int newDuration, String newRoomId, String newfinishTime, Model.AppointmentType newAppointmentType)
      {
         // TODO: implement
      }
      
      public void Update(String id, DateTime startTime, int duration, String roomId, Model.AppointmentType appointmentType)
      {
         // TODO: implement
      }
      
      public void Delete(String id)
      {
         // TODO: implement
      }
      
      public List<Operation> GetAll()
      {
         // TODO: implement
         return null;
      }
      
      public Operation GetByid(String id)
      {
         // TODO: implement
         return null;
      }
   
      
   */
    }
}