/***********************************************************************
 * Module:  OrderController.cs
 * Author:  Remica
 * Purpose: Definition of the Class Controller.OrderController
 ***********************************************************************/

using Model; using System; using System.Collections.Generic;

namespace Service
{
   public class OrderService
   {
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
      }
   
     
   
   }
}