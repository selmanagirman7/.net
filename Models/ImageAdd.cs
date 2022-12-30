using Microsoft.AspNetCore.Http;

namespace WebUI.Models
{
    public class ImageAdd
    {
        public int Id { get; set; }
        public IFormFile Name { get; set; }
    }
}
