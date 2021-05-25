/***********************************************************************
 * Module:  Room.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Room
 ***********************************************************************/

using Model;
using Service;
using System; using System.Collections.Generic;

namespace Controller
{
   public class RoomController
   {

        public RoomService RoomService = new RoomService();

        public void Save(Room r)
        {
            RoomService.Save(r);
        }

        public void Update(Room r)
        {
            RoomService.Update(r);
        }

        public void Delete(string id)
        {
            RoomService.Delete(id);
        }

        public Room GetById(string id)
        {
            return RoomService.GetById(id);
        }

        public List<Room> GetAll()
        {
            return RoomService.GetAll();
        }

        public List<Room> GetAllRoomsByEquipment(String name)
        {
            return RoomService.GetAllRoomsByEquipment(name);
        }
        public List<Room> GetByType(String type)
        {
            return RoomService.GetByType(type);
        }
        public List<Bed> GetFreeBeds(Room r)
        {
            return RoomService.GetFreeBeds(r);
        }

        /*
      public void Create(int newNumber, Model.RoomType newType, int newFloor, String newDescription)
      {
         // TODO: implement
      }
      
      public Model.Room Read(int number)
      {
         // TODO: implement
         return null;
      }
      
      public void Update(int newNumber, Model.RoomType newFloor, String newDesciption)
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
      }*/



    }
}