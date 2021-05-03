/***********************************************************************
 * Module:  User.cs
 * Author:  Vujke
 * Purpose: Definition of the Class User
 ***********************************************************************/

using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class User
   {
        public User()
        {}
        public User(string id, string username, string password, string name, string surname, string email, string address, string phone, DateTime d)
        {
            this.Id = id;
            this.Name = name;
            this.Username = username;
            this.Password = password;
            this.Surname = surname;
            this.EMail = email;
            this.Address = address;
            this.Phone = phone;
            this.DateOfBirth = d;
        }
      public String Id { get; set; }
      public String Username { get; set; }
        public String Password { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public String EMail { get; set; }
        public String Address { get; set; }
        public String Phone { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}