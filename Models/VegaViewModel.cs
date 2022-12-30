using Entity;
using System.Linq;

namespace WebUI.Models
{
    public class VegaViewModel
    {
        public IQueryable<Vega> Vegas { get; set; }

        public string Text { get; set; }

    }
}
