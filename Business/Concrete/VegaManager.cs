using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class VegaManager : IVegaService
    {
        IVegaDal _vegaDal;
        Vega vega  = new Vega();
        public VegaManager(IVegaDal vegaDal)
        {
            _vegaDal = vegaDal;
        }

        public void Add(Vega vega)
        {
            _vegaDal.Add(vega);
        }

        public void Delete(Vega vega)
        {
            _vegaDal.Delete(vega);
        }

        public List<Vega> GetAll()
        {

            return _vegaDal.GetAll();   
        }

        public List<Vega> GetAllByStringId(string strId)
        {
            return _vegaDal.GetList(x => x.Stok == strId).ToList();
        }

        public List<Vega> GetByCategory(int id)
        {
            return _vegaDal.List(x => x.CategoryId == id);
        }

        public List<Vega> GetById(int id)
        {
            return _vegaDal.GetList(x=>x.Id==id).ToList();
        }

        public Vega GetByStringId(string strId)
        {
            return _vegaDal.GetIdString(strId);
        }
        public Vega Get(int id)
        {
            return _vegaDal.GetById(id);
        }

        public List<Vega> DeleteList(int categoryId)
        {
            return _vegaDal.DeleteList(x=>x.CategoryId==categoryId);
        }
    }
}
