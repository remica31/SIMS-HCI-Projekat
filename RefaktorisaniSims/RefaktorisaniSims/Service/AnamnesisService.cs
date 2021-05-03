// File:    Allergen.cs
// Author:  LENOVO
// Created: Friday, April 9, 2021 20:59:39
// Purpose: Definition of Class Allergen
using Model;
using Repository;
using System; using System.Collections.Generic;


namespace Service
{
   public class AnamnesisService
   {
        public AnamnesisRepository anamnesisRepository = new AnamnesisRepository();


        public List<Anamnesis> GetAll()
        {
            return anamnesisRepository.GetAll();
        }

        public Anamnesis GetById(string id)
        {
            return anamnesisRepository.GetById(id);
        }

        public void Save(Anamnesis anamnesis)
        {
            anamnesisRepository.Save(anamnesis);


        }

        public void Delete(string id)
        {
            anamnesisRepository.Delete(id);
        }

        public void Update(Anamnesis anamnesis)
        {
            anamnesisRepository.Update(anamnesis);

        }
      



    }
}