using System;
using System.Collections.Generic;
using System.Text;

namespace DevBase.Entities.ORM.Concerte
{
    public class Category:BaseEntity
    {

        public string CategoryName { get; set; }

        public List<Product> Product { get; set; }
    }
}
