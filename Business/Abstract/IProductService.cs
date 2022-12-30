﻿using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        Product Get(int id);
        Product GetString(string id);

        void Add(Product product);
        void Update(Product product);   
        void Delete(Product product);
        List<Product> GetAll();
        List<Product> GetCategory();
    }
}
