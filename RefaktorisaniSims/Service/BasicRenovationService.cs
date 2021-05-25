/***********************************************************************
 * Module:  Renovation.cs
 * Author:  Vujke
 * Purpose: Definition of the Class Renovation
 ***********************************************************************/

using Model;
using Repository;
using System; using System.Collections.Generic;
using System.Windows;

namespace Service
{
   public class BasicRenovationService
   {
        public BasicRenovationRepository BasicRenovationRepository = new BasicRenovationRepository();

        public void Save(BasicRenovation hr)
        {
            List<BasicRenovation> requests = BasicRenovationRepository.GetAll();
            bool idExists = false;
            foreach (var req in requests)
            {
                if (hr.Id == req.Id)
                {
                    MessageBox.Show("Id already exists!");
                    idExists = true;

                }
            }
            if (!idExists)
            {
                BasicRenovationRepository.Save(hr);
            }
        }

        public void Delete(string id)
        {
            BasicRenovationRepository.Delete(id);
        }

        public BasicRenovation GetById(string id)
        {
            return BasicRenovationRepository.GetById(id);
        }

        public void Update(BasicRenovation hr)
        {
            BasicRenovationRepository.Update(hr);
        }

        public List<BasicRenovation> GetAll()
        {
            return BasicRenovationRepository.GetAll();
        }



    }
}