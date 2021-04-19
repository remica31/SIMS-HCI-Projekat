
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
        string filePath = @"C:\Users\Remica\Desktop\rema\Sims\Sims\Data\room.txt";
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
    public void createRoom(string newNumber, string newFloor, string newDescription)
    {
        /* Appointment newapp = new Appointment();
         newapp.Id = newId;
         newapp.Start = newStart;
         newapp.Finish = newFinish;
         newapp.Duration = newDuration;
         appointments.Add(newapp);*/
        string filePath1 = @"C:\Users\Remica\Desktop\rema\Sims\Sims\Data\room.txt";
        List<string> lines = new List<string>();
        lines = File.ReadAllLines(filePath1).ToList();
        string number = newNumber;//"A1";
        string floor = newFloor;//"12";
        string description = newDescription;//"1";
        string s10 = number + "," + "/" + "," + floor + "," + description + ",d1";
        lines.Add(s10);
        File.WriteAllLines(filePath1, lines);
    }
    public void updateRoom(int newNumber, int newFloor, string newDescription)
    {
        foreach (var room in rooms)
        {
            if (room.Number == newNumber && room.Floor==newFloor)
            {
                room.Number = newNumber;
                room.Floor = newFloor;
                room.Description = newDescription;
            }
        }

    }
    public void deleteRoom(int newNumber)
    {
        List<Room> newList = new List<Room>();
        foreach (var room in rooms)
        {
            if (room.Number != newNumber)
            {
                newList.Add(room);
            }
        }
        rooms = newList;
    }
        public void write()
    {
        string filePath1 = @"C:\Users\Remica\Desktop\rema\Sims\Sims\Data\room.txt";
        List<string> lines = new List<string>();
        foreach (var room in rooms)
        {
            string number =Convert.ToString(room.Number);//"A1";
            string floor = Convert.ToString(room.Floor);//"12";
            string description = room.Description;//"1";
            string s10 = number + "," + "/" + "," + floor + "," + description + ",d1";
            lines.Add(s10);
        }
        File.WriteAllLines(filePath1, lines);
    }



}