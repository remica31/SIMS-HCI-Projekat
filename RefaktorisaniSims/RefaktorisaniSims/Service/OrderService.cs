/***********************************************************************
 * Module:  OrderController.cs
 * Author:  Remica
 * Purpose: Definition of the Class Controller.OrderController
 ***********************************************************************/

using Model;
using Repository;
using System; using System.Collections.Generic;
using System.Windows;

namespace Service
{
   public class OrderService
   {
        public OrderRepository OrderRepository = new OrderRepository();

        public void Save(Order dr)
        {
            /*
            List<Order> orders = OrderRepository.GetAll();
            bool idExists = false;
            foreach (var req in orders)
            {
                if (dr.Id == req.Id)
                {
                    MessageBox.Show("Id already exists!");
                    idExists = true;

                }
            }
            if (!idExists)
            {
                OrderRepository.Save(dr);
            }*/

            OrderRepository.Save(dr);
        }

        public void Delete(string id)
        {
            OrderRepository.Delete(id);
        }

        public Order GetById(string id)
        {
            return OrderRepository.GetById(id);
        }

        public void Update(Order dr)
        {
            OrderRepository.Update(dr);
        }

        public List<Order> GetAll()
        {
            return OrderRepository.GetAll();
        }

        public List<Order> GetAllByName(String name)
        {
            return OrderRepository.GetAllByName(name);
        }

        public List<Order> GetAllByStatus(String status)
        {
            return OrderRepository.GetAllByStatus(status);
        }

        public List<Order> GetAllByNameAndStatus(String name, String status)
        {
            return OrderRepository.GetAllByNameAndStatus(name, status);
        }

        public List<Order> SortByDate(List<Order> orders)
        {
            return OrderRepository.SortByDate(orders);
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