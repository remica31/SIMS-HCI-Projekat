/***********************************************************************
 * Module:  PatientNote.cs
 * Author:  Milos
 * Purpose: Definition of the Class Model.PatientNote
 ***********************************************************************/

using System;
namespace Model
{


    public class PatientNotes
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public int Period { get; set; }
        public DateTime Time { get; set; }


        public PatientNotes() { }

        public PatientNotes(String id, String name, String description, int period, DateTime time)
        {

            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Period = period;
            this.Time = time;


        }



    }
}