using Microsoft.AspNetCore.Http;

namespace WebUI.Models
{
    public class VegaEdit
    {

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string? Stok { get; set; }
        public string? Name { get; set; }
        public string? MonyTyp { get; set; }
        public string? Iskonto { get; set; }
        public string? Price { get; set; }
        public IFormFile ImageUrl { get; set; }
        public bool Statu { get; set; }
    }
}
