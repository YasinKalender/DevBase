using System;
using System.Collections.Generic;
using System.Text;

namespace DevBase.Dto.DTOs.ProductDto
{
    public class ProductListDto
    {
        public int ID { get; set; }
        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public string Image { get; set; }
    }
}
