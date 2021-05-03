/***********************************************************************
 * Module:  UserRepository.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Repository.UserRepository
 ***********************************************************************/

using Model;
using System; using System.Collections.Generic;

namespace Repository
{
   public class UserRepository
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
   
   }
}