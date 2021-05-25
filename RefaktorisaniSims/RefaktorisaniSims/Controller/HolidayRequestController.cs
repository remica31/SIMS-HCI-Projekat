/***********************************************************************
 * Module:  Request.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Request
 ***********************************************************************/

using Model;
using Service;
using System; using System.Collections.Generic;

namespace Controller
{
    public class HolidayRequestController
    {
        public HolidayRequestService holidayRequestService = new HolidayRequestService();

        public void Save(HolidayRequest hr)
        {
            holidayRequestService.Save(hr);
        }

        public void Update(HolidayRequest hr)
        {
            holidayRequestService.Update(hr);
        }

        public void Delete(string id)
        {
            holidayRequestService.Delete(id);
        }

        public HolidayRequest GetById(string id)
        {
            return holidayRequestService.GetById(id);
        }

        public List<HolidayRequest> GetAll()
        {
            return holidayRequestService.GetAll();
        }

        public List<HolidayRequest> SearchByStatus(string status)
        {
            return holidayRequestService.SearchByStatus(status);
        }

        public List<HolidayRequest> SearchByDoctorId(string id)
        {
            return holidayRequestService.SearchByDoctorId(id);
        }

        public List<HolidayRequest> SortByDate(List<HolidayRequest> requests)
        {
            return holidayRequestService.SortByDate(requests);
        }

        public List<HolidayRequest> SearchByStatusAndDoctorId(string status, string id)
        {
            return holidayRequestService.SearchByStatusAndDoctorId(status, id);
        }

        /*

      public void Create(String newId, String newDescription, DateTime newSubmissionDate, int newDurationinDays, DateTime newStartDate)
      {
         // TODO: implement
      }
      
      public void Update(String newDescription, int newDurationInDays, DateTime newStardDate)
      {
         // TODO: implement
      }
      
      public void Delete(String id)
      {
         // TODO: implement
      }
      
      public HolidayRequest Read(String id)
      {
         // TODO: implement
         return null;
      }
      
      public List<HolidayRequest> ReadAll()
      {
         // TODO: implement
         return null;
      }
      
      public Model.StatusType UpdateStatus(Model.StatusType newStatus)
      {
         // TODO: implement
         return null;
      }
   
      */

    }
}