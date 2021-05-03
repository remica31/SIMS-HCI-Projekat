/***********************************************************************
 * Module:  Operations.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.Operations
 ***********************************************************************/

using Model;
using Service;
using System; using System.Collections.Generic;

namespace Controller
{
   public class OperationController
   {
        private OperationService operationService = new OperationService();

        public List<Operation> GetAll()
        {
            return operationService.GetAll();
        }

        public Operation GetById(string id)
        {
            return operationService.GetById(id);
        }

        public void Save(Operation operation)
        {
            operationService.Save(operation);
        }

        public void Delete(string id)
        {
            operationService.Delete(id);
        }

        public void Update(Operation operation)
        {
            operationService.Update(operation);
        }
        public List<Operation> GetByDoctorId(string id)
        {

            return operationService.GetByDoctorId(id);
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