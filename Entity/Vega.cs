using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Text;

namespace Entity
{
    public class Vega
    {

        [Key]
        public int Id { get; set; }
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

