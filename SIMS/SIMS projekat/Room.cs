

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

   public int Number;
   public RoomType Type;
   public int Floor;
   public String Description;

}