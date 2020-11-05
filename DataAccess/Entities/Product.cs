using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public virtual ProductDetails ProductDetails { get; set; }
    }
}
