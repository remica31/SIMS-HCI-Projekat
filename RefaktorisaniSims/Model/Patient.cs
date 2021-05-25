/***********************************************************************
 * Module:  Patient.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Patient
 ***********************************************************************/

using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class Patient
   {

        public bool isBlocked { get; set; }
        public int canclledAppCnt { get; set; }
        public Patient()
        {
        }
        public Patient(User user)
        {
            this.User = user;
        }
        public Patient(Guest guest)
        {
            var user = new User();
            user.Id = guest.Id;
            user.Name = guest.Name;
            user.Surname = guest.Surname;
            user.Username = guest.Username;
            user.Password = guest.Password;
            this.User = user;
            this.isBlocked = false;
            this.canclledAppCnt = 0; 
        }
        

          
      public User User { get; set; }
      public MedicalRecord medicalRecord { get; set; }
      public List<Appointment> appointments { get; set; }
   
   }
}