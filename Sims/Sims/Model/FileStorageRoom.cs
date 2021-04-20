/***********************************************************************
 * Module:  StorageAppoitmentDoctor.cs
 * Author:  Vujke
 * Purpose: Definition of the Class StorageAppoitmentDoctor
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Model
{
    public class FileStorageRoom
    {
        public string FileLocation;

        public FileStorageRoom()
        {
            equipment = new List<StaticEquipments>();
            equipment1 = new List<DinamicEquipments>();
          
        }

        public void Read()
        {
            equipment = new List<StaticEquipments>();
            string filePath = @"C:\Users\User\Downloads\kt\sims5\Sims\Sims\Data\staticequipment.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (var line in lines)
            {
                var newEquipment = new StaticEquipments();

                string[] entries = line.Split(',');

                newEquipment.Id = entries[0];
                newEquipment.Name = entries[1];
                newEquipment.warehouseId = entries[2];
                newEquipment.Quantity = Convert.ToInt32(entries[3]);
                equipment.Add(newEquipment);
            }
        }

        public void Create(string id, string name, string warehouseId, int quantity)
        {
            string filePath1 = @"C:\Users\User\Downloads\kt\sims5\Sims\Sims\Data\staticequipment.txt";
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath1).ToList();

            string newLine = id + "," + name + "," + warehouseId + "," + quantity.ToString();
            lines.Add(newLine);
            File.WriteAllLines(filePath1, lines);
        }

        public void updateEquipment(string id, string warehouseId, int quantity)
        {
            foreach (var eq in equipment)

            {
                if (eq.Id == id)
                {
                    eq.warehouseId = warehouseId;
                    eq.Quantity = quantity;
                }
            }

        }

        public void deleteEquipment(string id)
        {
            List<StaticEquipments> eqq = new List<StaticEquipments>();
            foreach (var eq in equipment)
            {
                if (eq.Id != id)
                {
                    eqq.Add(eq);
                }
            }
            equipment = eqq;
        }

        public void write()
        {
            string filePath1 = @"C:\Users\User\Downloads\kt\sims5\Sims\Sims\Data\staticequipment.txt";
            List<string> lines = new List<string>();
            foreach (var eq in equipment)
            {
                string id = Convert.ToString(eq.Id);//"A1";
                string name = Convert.ToString(eq.Name);//"12";
                string warehouseId = Convert.ToString(eq.warehouseId);//"1";
                int quantity = Convert.ToInt32(eq.Quantity);
                string s10 = id + "," + name + "," + warehouseId + "," + quantity.ToString();
                lines.Add(s10);
            }
            File.WriteAllLines(filePath1, lines);
        }
        public void deleteEquipment1(string id)
        {
            List<DinamicEquipments> eqq = new List<DinamicEquipments>();
            foreach (var eq in equipment1)
            {
                if (eq.Id != id)
                {
                    eqq.Add(eq);
                }
            }
            equipment1 = eqq;
        }
        public void updateEquipment1(string id, string warehouseId, int quantity)
        {
            foreach (var eq in equipment1)

            {
                if (eq.Id == id)
                {
                    eq.warehouseId = warehouseId;
                    eq.Quantity = quantity;
                }
            }

        }
        public void Read1()
        {
            equipment1 = new List<DinamicEquipments>();
            string filePath = @"C:\Users\User\Downloads\kt\sims5\Sims\Sims\Data\dynequipment.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (var line in lines)
            {
                var newEquipment = new DinamicEquipments();

                string[] entries = line.Split(',');

                newEquipment.Id = entries[0];
                newEquipment.Name = entries[1];
                newEquipment.warehouseId = entries[2];
                newEquipment.Quantity = Convert.ToInt32(entries[3]);
                equipment1.Add(newEquipment);
            }
        }
        public void Create1(string id, string name, string warehouseId, int quantity)
        {
            string filePath1 = @"C:\Users\User\Downloads\kt\sims5\Sims\Sims\Data\dynequipment.txt";
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath1).ToList();

            string newLine = id + "," + name + "," + warehouseId + "," + quantity.ToString();
            lines.Add(newLine);
            File.WriteAllLines(filePath1, lines);
        }
        public void write1()
        {
            string filePath1 = @"C:\Users\User\Downloads\kt\sims5\Sims\Sims\Data\dynequipment.txt";
            List<string> lines = new List<string>();
            foreach (var eq in equipment1)
            {
                string id = Convert.ToString(eq.Id);//"A1";
                string name = Convert.ToString(eq.Name);//"12";
                string warehouseId = Convert.ToString(eq.warehouseId);//"1";
                int quantity = Convert.ToInt32(eq.Quantity);
                string s10 = id + "," + name + "," + warehouseId + "," + quantity.ToString();
                lines.Add(s10);
            }
            File.WriteAllLines(filePath1, lines);
        }
        public List<DinamicEquipments> equipment1;
        public List<DinamicEquipments> getAll1()
        {
            return equipment1;
        }

        public List<StaticEquipments> equipment;
        public List<StaticEquipments> getAll()
        {
            return equipment;
        }
        
       



    }
}