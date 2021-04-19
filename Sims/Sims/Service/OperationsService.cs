/***********************************************************************
 * Module:  Operations.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Model.Operations
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;

namespace Service
{
   public class OperationsService
   {
      public void Create(String inewd, double newStart, double newDuration, Model.Room newRoom)
      {
         // TODO: implement
      }
      
      public void Update(String id, double start, double duration, Model.Room room)
      {
         // TODO: implement
      }
      
      public void Delete()
      {
         // TODO: implement
      }
      
      public List<Operations> GetAll()
      {
         // TODO: implement
         return null;
      }
      
      public Operations GetByid()
      {
         // TODO: implement
         return null;
      }
   
      public OperationsRepository operationsRepository;
   
   }
}