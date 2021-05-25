/***********************************************************************
 * Module:  Patient.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Patient
 ***********************************************************************/

using Model;
using Service;
using System; using System.Collections.Generic;


namespace Controller
{
   public class UserController
   {
      public List<User> GetAll()
      {
         // TODO: implement
         return null;
      }
      
      public User GetById(String id)
      {
         // TODO: implement
         return null;
      }
      
      public void Create(String newID, String newUsername, String newPassword, String newName, String newSurname, String newEMail, String newAddress, String newPhone, DateTime newDateOfBirth)
      {
         // TODO: implement
      }
      
      public void Update(String newEmail, String newAddress, String newPhone)
      {
         // TODO: implement
      }
      
      public void Delete(String id)
      {
         // TODO: implement
      }
   
      public UserService userService;
   
   }
}