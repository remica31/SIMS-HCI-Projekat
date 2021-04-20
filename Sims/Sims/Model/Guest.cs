/***********************************************************************
 * Module:  Guest.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.Guest
 ***********************************************************************/

using System;

namespace Model
{
   public class Guest
   {
      public void Create(String jmbg, String newName, String newSurname, String newUsername, String newPassword)
      {
         // TODO: implement
      }
   
      public Operations operations;
      public Appointment appointment;
      public User user;
   
      public String Jmbg { get; set; }
      public String Name { get; set; }
        public String Surname { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }

    }
}