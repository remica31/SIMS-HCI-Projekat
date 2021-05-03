/***********************************************************************
 * Module:  Guest.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.Guest
 ***********************************************************************/

using Model;
using Service;
using System; using System.Collections.Generic;

namespace Controller
{
   public class GuestController
   {
        private GuestService guestService = new GuestService();


        public Guest GetById(string id)
        {
            return guestService.GetById(id);
        }

        public void Save(Guest guest)
        {
            guestService.Save(guest);
        }
        /*
      public void Create(String jmbg, String newName, String newSurname, String newUsername, String newPassword)
      {
         // TODO: implement
      }
   
     */

    }
}