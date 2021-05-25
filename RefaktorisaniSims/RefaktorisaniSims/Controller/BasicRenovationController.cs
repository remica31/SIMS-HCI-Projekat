/***********************************************************************
 * Module:  Renovation.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Renovation
 ***********************************************************************/

using Model;
using Service;
using System; using System.Collections.Generic;

namespace Controller
{
   public class BasicRenovationController
   {
        public BasicRenovationService BasicRenovationService = new BasicRenovationService();

        public void Save(BasicRenovation hr)
        {
            BasicRenovationService.Save(hr);
        }

        public void Update(BasicRenovation hr)
        {
            BasicRenovationService.Update(hr);
        }

        public void Delete(string id)
        {
            BasicRenovationService.Delete(id);
        }

        public BasicRenovation GetById(string id)
        {
            return BasicRenovationService.GetById(id);
        }

        public List<BasicRenovation> GetAll()
        {
            return BasicRenovationService.GetAll();
        }
        /*
      public void Create(String id, DateTime date, String roomId)
      {
         // TODO: implement
      }
      
      public void Update(String id, DateTime date)
      {
         // TODO: implement
      }
      
      public void Delete(String id)
      {
         // TODO: implement
      }
      
      public BasicRenovationController GetById(String id)
      {
         // TODO: implement
         return null;
      }
      
      public List<BasicRenovation> GetAll()
      {
         // TODO: implement
         return null;
      }*/



    }
}