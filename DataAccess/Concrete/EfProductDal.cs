using DataAccess.Abstract;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfProductDal : EfGenericRepository<Product>, IProductDal
    {
        public List<Product> GetListCategory()
        {
            using (var context=new Context())
            {
                return context.Products.Include(x => x.CategoryId).ToList();
            }
        }
    }
}
