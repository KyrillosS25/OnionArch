using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public interface IProductService
    {
        IQueryable<Product> GetProduct();
        Product GetProduct(int id);
    }
}
