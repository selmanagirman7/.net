using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IVegaService
    {
        void Add(Vega vega);
        Vega GetByStringId(string strId);
        List<Vega> GetAll();
        List<Vega> GetAllByStringId(string strId);
        void Delete(Vega vega);

        List<Vega> GetByCategory(int id);
        List<Vega> DeleteList(int categoryId);
    }
}
