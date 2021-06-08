/***********************************************************************
 * Module:  Room.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Room
 ***********************************************************************/

using Model;
using Repository;
using System; using System.Collections.Generic;
using System.Windows;

namespace Service
{
   public class RoomService
   {
        public RoomRepository RoomRepository = new RoomRepository();
        public StaticEquipmentRepository equipmentRepository = new StaticEquipmentRepository();

        public void Save(Room r)
        {
            List<Room> requests = RoomRepository.GetAll();
            bool idExists = false;
            foreach (var req in requests)
            {
                if (r.Id == req.Id)
                {
                    MessageBox.Show("Id already exists!");
                    idExists = true;

                }
            }
            if (!idExists)
            {
                RoomRepository.Save(r);
            }
        }

        public void Delete(string id)
        {
            RoomRepository.Delete(id);
        }

        public Room GetById(string id)
        {
            return RoomRepository.GetById(id);
        }

        public void Update(Room r)
        {
            RoomRepository.Update(r);
        }

        public List<Room> GetAll()
        {
            return RoomRepository.GetAll();
        }

        public List<Room> GetAllRoomsByEquipment(String name)
        {
            return RoomRepository.GetAllRoomsByEquipment(name);
        }
        public List<Room> GetByType(String type)
        {
            return RoomRepository.GetByType(type);
        }
        public List<Bed> GetFreeBeds(Room r)
        {
            return RoomRepository.GetFreeBeds(r);
        }

        public Room MergeRooms(string room1Id, string room2Id)
        {
            var eqForTransfer = equipmentRepository.GetAllByRoomId(room2Id);
            foreach (var eq in eqForTransfer)
            {
                eq.RoomId = room1Id;
                equipmentRepository.Update(eq);
            }

            RoomRepository.Delete(room2Id);
            
            return RoomRepository.GetById(room1Id);
        }

        public void SplitRooms(string room1Id, string room2Id)
        {
            var roomForSplit = RoomRepository.GetById(room1Id);
            
            var newRoom = new Room(room2Id, roomForSplit.Number + 1, "Ordination", roomForSplit.Floor, "description");
            var eqForTransfer = equipmentRepository.GetAllByRoomId(room1Id);
            for (int i = 0; i < eqForTransfer.Count / 2; i++)
            {
                eqForTransfer[i].RoomId = room2Id;
                equipmentRepository.Update(eqForTransfer[i]);
            }
            RoomRepository.Save(newRoom);
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
      }
      
      public int getAll__()
      {
         // TODO: implement
         return 0;
      }*/



    }
}