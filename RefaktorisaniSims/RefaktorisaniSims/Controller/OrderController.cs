/***********************************************************************
 * Module:  OrderController.cs
 * Author:  Remica
 * Purpose: Definition of the Class Controller.OrderController
 ***********************************************************************/

using Model;
using Service;
using System; using System.Collections.Generic;

namespace Controller
{
   public class OrderController
   {
        public OrderService OrderService = new OrderService();

        public void Save(Order hr)
        {
            OrderService.Save(hr);
        }

        public void Update(Order hr)
        {
            OrderService.Update(hr);
        }

        public void Delete(string id)
        {
            OrderService.Delete(id);
        }

        public Order GetById(string id)
        {
            return OrderService.GetById(id);
        }

        public List<Order> GetAll()
        {
            return OrderService.GetAll();
        }

        public List<Order> GetAllByName(String name)
        {
            return OrderService.GetAllByName(name);
        }

        public List<Order> GetAllByStatus(String status)
        {
            return OrderService.GetAllByStatus(status);
        }

        public List<Order> GetAllByNameAndStatus(String name, String status)
        {
            return OrderService.GetAllByNameAndStatus(name, status);
        }

        public List<Order> SortByDate(List<Order> orders)
        {
            return OrderService.SortByDate(orders);
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