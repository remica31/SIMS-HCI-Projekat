/***********************************************************************
 * Module:  OrderController.cs
 * Author:  Remica
 * Purpose: Definition of the Class Controller.OrderController
 ***********************************************************************/

using Model;
using Newtonsoft.Json;
using System; using System.Collections.Generic;
using System.IO;

namespace Repository
{
   public class OrderRepository
   {
        private readonly string fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\RefaktorisaniSims\\Data\\Orders.json";
        public List<Order> orders = new List<Order>();

        public OrderRepository()
        {
            ReadJson();
        }

        public void ReadJson()
        {
            if (!File.Exists(fileLocation))
            {
                File.Create(fileLocation).Close();
            }

            using (StreamReader r = new StreamReader(fileLocation))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    orders = JsonConvert.DeserializeObject<List<Order>>(json);
                }
            }
        }

        public void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(orders);
            File.WriteAllText(fileLocation, json);
        }

        public void Save(Order dr)
        {
            ReadJson();
            orders.Add(dr);
            WriteToJson();
        }

        public void Delete(string id)
        {
            ReadJson();

            int index = orders.FindIndex(obj => obj.Id == id);
            orders.RemoveAt(index);
            WriteToJson();
        }

        public void Update(Order dr)
        {
            ReadJson();
            int index = orders.FindIndex(obj => obj.Id == dr.Id);
            orders[index] = dr;
            WriteToJson();
        }
        public Order GetById(String id)
        {
            // TODO: implement
            ReadJson();
            return orders.Find(obj => obj.Id == id);
        }
        public List<Order> GetAll()
        {
            ReadJson();
            return orders;
        }

        public List<Order> GetAllByName(String name)
        {
            ReadJson();
            var newOrders = new List<Order>();
            foreach (var order in orders)
            {
                if (name == order.DynamicEquipmentName)
                {
                    newOrders.Add(order);
                }
            }
            
            return newOrders;
        }

        public List<Order> GetAllByStatus(String status)
        {
            ReadJson();
            var newOrders = new List<Order>();
            foreach (var order in orders)
            {
                if (order.Status == status)
                {
                    newOrders.Add(order);
                }
            }
            
            return newOrders;
        }

        public List<Order> GetAllByNameAndStatus(String name, String status)
        {
            ReadJson();
            var newOrders = new List<Order>();
            foreach (var order in orders)
            {
                if (order.DynamicEquipmentName == name && order.Status == status)
                {
                    newOrders.Add(order);
                }
            }
            
            return newOrders;
        }

        public List<Order> SortByDate(List<Order> sortedOrders)
        {
            ReadJson();


            sortedOrders.Sort((x, y) => DateTime.Compare(x.Date, y.Date));
            return sortedOrders;
        }
        /*
      public void Create(String id, String dynamicEquipmentName, int quantity, DateTime date, Model.OrderStatus status)
      {
         // TODO: implement
      }
      
      public void Update(String id, String dynamicEquipmentName, int quantity, Model.OrderStatus status, DateTime date)
      {
         // TODO: implement
      }
      
      public void Delete(String id)
      {
         // TODO: implement
      }
      
      public Model.Order GetById(String id)
      {
         // TODO: implement
         return null;
      }
      
      public List<Order> GetAll()
      {
         // TODO: implement
         return null;
      }
      
      public List<Order> SearchByName(String name)
      {
         // TODO: implement
         return null;
      }
      
      public List<Order> SearchByStatus(Model.OrderStatus status)
      {
         // TODO: implement
         return null;
      }*/

    }
}