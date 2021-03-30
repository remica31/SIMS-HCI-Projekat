
using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class FileStorageRoom
{
    public FileStorageRoom()
    {
        rooms = new List<Room>();
        string filePath = @"C:\Users\Asus\Desktop\sims5\Sims\Sims\Data\room.txt";
        List<string> lines = File.ReadAllLines(filePath).ToList();

        foreach (var line in lines)
        {
            var newRoom = new Room();

            string[] entries = line.Split(',');

            newRoom.Number = Convert.ToInt32(entries[0]);
            //newRoom.Type = (RoomType)Enum.Parse(typeof(RoomType), proba);
            newRoom.Floor = Convert.ToInt32(entries[2]);
            newRoom.Description = entries[3];
            rooms.Add(newRoom);

            //newApp.Type = (AppointmentType)Enum.Parse(typeof(AppointmentType), proba)
        }

    }

    public List<Room> rooms;
    public List<Room> GetRooms()
    {
        return rooms;
    }




}