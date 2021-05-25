/***********************************************************************
 * Module:  Guest.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.Guest
 ***********************************************************************/

using Model;
using Repository;
using System; using System.Collections.Generic;

namespace Service
{
   public class GuestService
   {
        public GuestRepository guestRepository = new GuestRepository();

        public Guest GetById(string id)
        {
            return guestRepository.GetById(id);
        }

        public void Save(Guest guest)
        {
            guestRepository.Save(guest);


        }
        /*
      public void Create(String jmbg, String newName, String newSurname, String newUsername, String newPassword)
      {
         // TODO: implement
      }
   
      
   */
    }
}