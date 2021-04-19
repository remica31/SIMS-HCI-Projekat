/***********************************************************************
 * Module:  Request.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Request
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;

namespace Service
{
   public class HolidayRequestService
   {
      public void Create(String newId, String newDescription, int newDuration, String newStartDuration)
      {
         // TODO: implement
      }
      
      public void Update(String newDescription, int newDuration)
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
      
      public List<Request> ReadAll()
      {
         // TODO: implement
         return null;
      }
   
      public HolidayRequestRepository holidayRequestRepository;
   
   }
}