using System;
using System.Collections.Generic;
using System.Text;

namespace DevBase.Entities.ORM.Concerte
{
    public class Product:BaseEntity
    {

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public string Image { get; set; }

        public int CategoryID { get; set; }

        public Category Category { get; set; }
    }
}
