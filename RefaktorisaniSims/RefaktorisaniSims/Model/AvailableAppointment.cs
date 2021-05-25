/***********************************************************************
 * Module:  Appointment.cs
 * Author:  User
 * Purpose: Definition of the Class Appointment
 ***********************************************************************/

using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class AvailableAppointment
   {
       public AvailableAppointment()
        {

        }
        public AvailableAppointment(string newId, DateTime newStartTime, int newDuration, int hours, int minutes)
        {
            int day=newStartTime.Day;
            int month=newStartTime.Month;
            int year=newStartTime.Year;
            DateTime NewStart = new DateTime(year, month, day, hours, minutes, 0);
            this.Id = newId;
            this.StartTime = NewStart;
            this.Duration = newDuration;
            //this.Type = newType;
            this.FinishTime = StartTime.AddMinutes(Duration);
        }
        public AvailableAppointment(string newId, DateTime newStartTime, int newDuration, int hours, int minutes, Doctor doctor, Patient patient)
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
        }
        public AvailableAppointment(string newId, DateTime newStartTime, int newDuration, int hours, int minutes, Doctor doctor)
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
        }
        public String Id { set; get; }
      public DateTime StartTime { set; get; }
        public int Duration { set; get; }
        public String Type { set; get; }
        public DateTime FinishTime { set; get; }

        public Doctor doctor { set; get; }
        public Patient patient { set; get; }

    }
}