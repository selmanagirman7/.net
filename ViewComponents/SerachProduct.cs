using Business.Concrete;
using DataAccess;
using DataAccess.Concrete;
using Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace WebUI.ViewComponents
{
    public class SerachProduct:ViewComponent
    {
        VegaManager vegaManager = new VegaManager(new EfVegaDal());
        Context _context = new Context();
        public IViewComponentResult Invoke(string SerachText="")
        {
            List<Vega> vega;
            if (SerachText !="" && SerachText!=null)
            {
                vega=_context.VegaProducts
                    .Where(x => x.Name.Contains( SerachText))
                    .ToList();
            }
            else
            {
                vega = _context.VegaProducts.ToList();
            }
            
            return View(vega);
        }
    }
}
