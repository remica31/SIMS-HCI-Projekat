

using System;
using System.Collections.Generic;

public class Room
{
    public Room() { }

    public void Create(int newNumber, RoomType newType, int newFloor, String newDescription)
    {
        var room = new Room();
        room.Number = newNumber;
        room.Type = newType;
        room.Floor = newFloor;
        room.Description = newDescription;
        rooms.Add(room);
    }

    public Room Read(int number)
    {
        foreach (var room in rooms)
        {
            if (number == room.Number)
            {
                return room;
            }
        }
        return null;
    }

    public void Update(int newNumber, int newFloor, String newDesciption)
    {
        Number = newNumber;
        Floor = newFloor;
        Description = newDesciption;
    }

    public void Delete(int number)
    {
        foreach (var room in rooms)
        {
            if (number == room.Number)
            {
                rooms.Remove(room);
            }
        }
    }

    public List<Room> GetAll()
    {
        return rooms;
    }

    public int Number { get; set; }
    public RoomType Type;
    public int Floor { get; set; }
    public String Description { get; set; }

    // public Renovation renovation { get; set; }
    public Doctor doctor { get; set; }
    public List<Room> rooms = new List<Room>();
    public List<Room> GetRooms()
    {
        return rooms;
    }

}