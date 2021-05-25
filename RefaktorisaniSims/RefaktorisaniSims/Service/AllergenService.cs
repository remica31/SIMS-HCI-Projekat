/***********************************************************************
 * Module:  AllergenController.cs
 * Author:  Remica
 * Purpose: Definition of the Class Controller.AllergenController
 ***********************************************************************/

using Model;
using Repository;
using System; using System.Collections.Generic;


namespace Service
{
   public class AllergenService
   {
        public AllergenRepository allergenRepository = new AllergenRepository();


        public List<Allergen> GetAll()
        {
            return allergenRepository.GetAll();
        }

        public Allergen GetById(string id)
        {
            return allergenRepository.GetById(id);
        }

        public void Save(Allergen allergen)
        {
            allergenRepository.Save(allergen);


        }

        public void Delete(string id)
        {
            allergenRepository.Delete(id);
        }

        public void Update(Allergen allergen)
        {
            allergenRepository.Update(allergen);

        }
        public Boolean isAllergic(string patientId, Medicine med)
        {
            List<Allergen> allergens = allergenRepository.GetByPatient(patientId);
            var ingredients = med.Ingredients.Split(',');
            foreach (var allergen in allergens)
            {
                foreach (var ingredient in ingredients)
                {
                    if (allergen.Name == ingredient)
                    {
                        return true;                     
                    }
                }
            }
            return false;
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