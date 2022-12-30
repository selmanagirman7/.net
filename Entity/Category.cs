using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity
{
    public class Category
    {

        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
