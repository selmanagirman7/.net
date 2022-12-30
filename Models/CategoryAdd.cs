namespace WebUI.Models
{
    public class CategoryAdd
    {
        public string? Name { get; set; }
        public string? NameEng { get; set; }
        public string? NameDe { get; set; }
        public IFormFile ImagePath { get; set; }
        public bool Statu { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
