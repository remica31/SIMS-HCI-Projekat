// File:    Allergen.cs
// Author:  LENOVO
// Created: Friday, April 9, 2021 20:59:39
// Purpose: Definition of Class Allergen

using Model;
using System;
using System.Collections.Generic;

namespace Model
{
   public class Allergen
   {
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
   
      public String Id;
      public String name;
      public String Description;
   
   }
}