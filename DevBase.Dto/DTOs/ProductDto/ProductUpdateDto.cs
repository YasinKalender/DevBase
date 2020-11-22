using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBase.Dto.DTOs.ProductDto
{
    public class ProductUpdateDto:BaseDto
    {


        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public string Image { get; set; }

        public int CategoryID { get; set; }
    }
}
