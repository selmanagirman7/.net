using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace WebUI.Models
{
	public class VegeSelectModel
    {
        
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string? Stok { get; set; }
        public string? Name { get; set; }
        public string? MonyTyp { get; set; }
        public string? Iskonto { get; set; }
        public string? Price { get; set; }
        public string? ImageUrl { get; set; }
        public bool Statu { get; set; }

        public SelectListItem Prd { get; set; } 
    }
}
