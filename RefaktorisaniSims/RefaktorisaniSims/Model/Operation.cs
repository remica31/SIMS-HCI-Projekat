/***********************************************************************
 * Module:  Operation.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.Operation
 ***********************************************************************/

using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class Operation
   {
        public Operation() { }
        public Operation(string newId, DateTime newStartTime, int newDuration, int hours, int minutes, Doctor doctor, Patient patient)
        {
            int day = newStartTime.Day;
            int month = newStartTime.Month;
            int year = newStartTime.Year;
            DateTime NewStart = new DateTime(year, month, day, hours, minutes, 0);
            this.Id = newId;
            this.StartTime = NewStart;
            this.Duration = newDuration;
            //this.Type = newType;
            this.FinishTime = StartTime.AddMinutes(Duration);
            this.doctor = doctor;
            this.patient = patient;
            //this.Room=room;
        }
        public Operation(string newId, DateTime newStartTime, int newDuration, int hours, int minutes, Doctor doctor, Patient patient, Room room)
        {
            int day = newStartTime.Day;
            int month = newStartTime.Month;
            int year = newStartTime.Year;
            DateTime NewStart = new DateTime(year, month, day, hours, minutes, 0);
            this.Id = newId;
            this.StartTime = NewStart;
            this.Duration = newDuration;
            //this.Type = newType;
            this.FinishTime = StartTime.AddMinutes(Duration);
            this.doctor = doctor;
            this.patient = patient;
            this.Room=room;
        }
        public String Id { set; get; }
      public DateTime StartTime { set; get; }
        public int Duration { set; get; }
        public Room Room { set; get; }
        public String Type { set; get; }
        public DateTime FinishTime { set; get; }

       
        public Doctor doctor { set; get; }
        public Patient patient { set; get; }

    }
}