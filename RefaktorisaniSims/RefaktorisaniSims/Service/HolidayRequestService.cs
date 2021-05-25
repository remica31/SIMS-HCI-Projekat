/***********************************************************************
 * Module:  Request.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Request
 ***********************************************************************/

using Model;
using Repository;
using System; using System.Collections.Generic;
using System.Windows;

namespace Service
{ 
 public class HolidayRequestService
{
    public HolidayRequestRepository holidayRequestRepository = new HolidayRequestRepository();

    public void Save(HolidayRequest hr)
    {
        List<HolidayRequest> requests = holidayRequestRepository.GetAll();
        bool idExists = false;
        foreach (var req in requests)
        {
            if (hr.Id == req.Id)
            {
                MessageBox.Show("Id already exists!");
                idExists = true;

            }
        }
        if (!idExists)
        {
            holidayRequestRepository.Save(hr);
        }
    }

    public void Delete(string id)
    {
        holidayRequestRepository.Delete(id);
    }

    public HolidayRequest GetById(string id)
    {
        return holidayRequestRepository.GetById(id);
    }

    public void Update(HolidayRequest hr)
    {
        holidayRequestRepository.Update(hr);
    }

    public List<HolidayRequest> GetAll()
    {
        return holidayRequestRepository.GetAll();
    }

        public List<HolidayRequest> SearchByStatusAndDoctorId(string status, string id)
        {
            return holidayRequestRepository.SearchByStatusAndDoctorId(status, id);
        }

        public List<HolidayRequest> SearchByStatus(string status)
        {
            return holidayRequestRepository.SearchByStatus(status);
        }

        public List<HolidayRequest> SearchByDoctorId(string id)
        {
            return holidayRequestRepository.SearchByDoctorId(id);
        }


        public List<HolidayRequest> SortByDate(List<HolidayRequest> sortedHolidayRequests)
        {
            sortedHolidayRequests.Sort((x, y) => DateTime.Compare(x.StartDate, y.StartDate));
            return sortedHolidayRequests;
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