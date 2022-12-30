using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity
{
    public class Product
    {
        [Key]
        public string ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ImgPath { get; set; }
        public string Metarial { get; set; }
        public string SeatAngle { get; set; }
        public string TotalWeight { get; set; }
        public string Dimensions { get; set; }
        public string BoxSize { get; set; }
        public string BoxSizeEng { get; set; }
        public string ThumbDesc { get; set; }
        public string ImgAlt { get; set; }
    }

}
