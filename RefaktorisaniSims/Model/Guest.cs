/***********************************************************************
 * Module:  Guest.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.Guest
 ***********************************************************************/

using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class Guest
   {
        public Guest() { }
        public Guest(string newId, string newNema, string newSurname, string newUsername, string newPassword)
        {
            Id = newId;
            Name = newNema;
            Surname = newSurname;
            Username = newUsername;
            Password = newPassword;
        }
      public String Id { set; get; }
      public String Name { set; get; }
        public String Surname { set; get; }
        public String Username { set; get; }
        public String Password { set; get; }

        public Operation operation;
      public Appointment appointment;
   
   }
}