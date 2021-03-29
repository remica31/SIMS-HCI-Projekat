/***********************************************************************
 * Module:  Room.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Room
 ***********************************************************************/

using System;
using System.Collections.Generic;


public class Room
{
   public void Create(int newNumber, RoomType newType, int newFloor, String newDescription)
   {
      // TODO: implement
   }
   
   public Room Read(int number)
   {
      // TODO: implement
      return null;
   }
   
   public void Update(int newNumber, RoomType newFloor, String newDesciption)
   {
      // TODO: implement
   }
   
   public void Delete(int number)
   {
      // TODO: implement
   }
   
   public List<Room> GetAll()
   {
      // TODO: implement
      return null;
   }

   public Renovation renovation;
   public Doctor doctor;

   private int Number;
   private RoomType Type;
   private int Floor;
   private String Description;

}