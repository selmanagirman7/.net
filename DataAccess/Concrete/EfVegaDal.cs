using DataAccess.Abstract;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfVegaDal:EfGenericRepository<Vega>,IVegaDal
    {

        private Context _context;

        public List<Vega> DeleteList(Expression<Func<Vega, bool>> filter)
        {
            using (var context = new Context())
            {
                     return filter == null
                    ? context.Set<Vega>().ToList()
                    : context.Set<Vega>().Where(filter).ToList();

            }
        }
    }
}
