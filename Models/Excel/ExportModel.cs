namespace WebUI.Models.Excel
{
    public class ExportModel
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string? Stok { get; set; }
        public string? Name { get; set; }
        public string? MonyTyp { get; set; }
        public string? Iskonto { get; set; }
        public string? Price { get; set; }
        public string? ImageUrl { get; set; }

        public string KeyWords { get; set; }
    }
}
