/***********************************************************************
 * Module:  Request.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Request
 ***********************************************************************/

using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class HolidayRequest
   {
        public String Id { get; set; }
        public String Description { get; set; }
        public DateTime DateOfSubmissionRequest { get; set; }
        public int DurationInDays { get; set; }
        public String Status { get; set; }
        public DateTime StartDate { get; set; }
        public String WardensComment { get; set; }
        public Doctor doctor { get; set; }

    }
}