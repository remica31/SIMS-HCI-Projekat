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
   
      private String Jmbg;
      private String Name;
      private String Surname;
      private String Username;
      private String Password;
   
   }
}