using Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IVegaDal:IGenericRepository<Vega>
    {
        List<Vega> DeleteList(Expression<Func<Vega, bool>> filter);

    }
}
