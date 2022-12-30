using Microsoft.AspNetCore.Http;

namespace WebUI.Models
{
    public class ProductAdd
    {
        public string? Stok { get; set; }
        public string? Name { get; set; }
        public string? Brand { get; set; }
        public int Price { get; set; }
        public string? Kdv { get; set; }
        public IFormFile ImageUrl { get; set; }

    }
}
