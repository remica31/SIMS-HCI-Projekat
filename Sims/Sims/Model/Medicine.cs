/***********************************************************************
 * Module:  Medicine.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.Medicine
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;

namespace Model
{
   public class Medicine
   {
      public Medicine Read(String id)
      {
         // TODO: implement
         return null;
      }
      
      public List<Medicine> ReadAll()
      {
         // TODO: implement
         return null;
      }
   
      public String Id { get; set; }
      public String Name { get; set; }
      public String Description { get; set; }
   
   }
}