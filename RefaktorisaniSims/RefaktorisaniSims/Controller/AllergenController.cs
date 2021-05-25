/***********************************************************************
 * Module:  AllergenController.cs
 * Author:  Remica
 * Purpose: Definition of the Class Controller.AllergenController
 ***********************************************************************/


using Model;
using Service;
using System; using System.Collections.Generic;


namespace Controller
{
   public class AllergenController
   {
        private AllergenService allergenService = new AllergenService();

        public List<Allergen> GetAll()
        {
            return allergenService.GetAll();
        }

        public Allergen GetById(string id)
        {
            return allergenService.GetById(id);
        }

        public void Save(Allergen allergen)
        {
            allergenService.Save(allergen);
        }

        public void Delete(string id)
        {
            allergenService.Delete(id);
        }

        public void Update(Allergen allergen)
        {
            allergenService.Update(allergen);
        }
        public Boolean isAllergic(string patientId, Medicine med)
        {
            return allergenService.isAllergic(patientId, med);
        }

        /*
      public void Create(String newId, String newName, String newDescription)
      {
         // TODO: implement
      }
      
      public void Update(String newId, String newName, String newDescription)
      {
         // TODO: implement
      }
      
      public List<Allergen> ReadAll()
      {
         // TODO: implement
         return null;
      }
      
      public Allergen ReadById(String id)
      {
         // TODO: implement
         return null;
      }
      
      public void Delete()
      {
         // TODO: implement
      }
   */

    }
}