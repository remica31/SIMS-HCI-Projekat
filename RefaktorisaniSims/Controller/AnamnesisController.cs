// File:    Allergen.cs
// Author:  LENOVO
// Created: Friday, April 9, 2021 20:59:39
// Purpose: Definition of Class Allergen

using Model;
using Service;
using System; using System.Collections.Generic;


namespace Controller
{
   public class AnamnesisController
   {
        private AnamnesisService anamnesisService = new AnamnesisService();

        public List<Anamnesis> GetAll()
        {
            return anamnesisService.GetAll();
        }

        public Anamnesis GetById(string id)
        {
            return anamnesisService.GetById(id);
        }

        public void Save(Anamnesis anamnesis)
        {
            anamnesisService.Save(anamnesis);
        }

        public void Delete(string id)
        {
            anamnesisService.Delete(id);
        }

        public void Update(Anamnesis anamnesis)
        {
            anamnesisService.Update(anamnesis);
        }
        /*
      public void Create(String newid, String newName, String newDescription, DateTime newDate)
      {
         // TODO: implement
      }
      
      public void Update(String newid, String newName, String newDescription, DateTime newDate)
      {
         // TODO: implement
      }
      
      public List<Anamnesis> ReadAll()
      {
         // TODO: implement
         return null;
      }
   
      */

    }
}