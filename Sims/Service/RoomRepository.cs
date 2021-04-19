/***********************************************************************
 * Module:  RoomRepository.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Repository.RoomRepository
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;

namespace Service
{
   public class RoomRepository
   {
      public Model.Room Read(int number)
      {
         // TODO: implement
         return null;
      }
      
      public void Update(int newNumber, Model.RoomType newFloor, String newDesciption)
      {
         // TODO: implement
      }
      
      public List<Room> ReadAll()
      {
         // TODO: implement
         return null;
      }
      
      public void Create(int newNumber, Model.RoomType newType, int newFlore, String newDescription)
      {
         // TODO: implement
      }
      
      public void Delete(int number)
      {
         // TODO: implement
      }
   
   }
}