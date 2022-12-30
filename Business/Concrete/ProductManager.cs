using Business.Abstract;
using DataAccess.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public Product Get(int id)
        {
            return _productDal.GetById(id);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
        public List<Product> GetListByCategory(int categoryId)
        {
            return _productDal.GetList(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetDetail(string id)
        {
            return _productDal.GetList(x => x.ProductId == id).ToList();
        }

        public List<Product> GetCategory()
        {
            return _productDal.GetListCategory();
        }

        public Product GetString(string id)
        {
            return _productDal.GetIdString(id);

        }
    }
}
