﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemApplication.DAL;
using StockManagementSystemApplication.Modals;

namespace StockManagementSystemApplication.BLL
{

  
    public  class CatagoryManager
    {
        CatagoryRepository catagoryRepository = new CatagoryRepository();
        public bool Add(Catagory catagory)
        {
            if (catagory != null && catagory.Name.Length < 3)
            {
                throw new Exception("Invalid Name");
            }

            bool isValid = catagoryRepository.Add(catagory);
            return isValid;

        }
    }
}
