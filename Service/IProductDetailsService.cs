using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public interface IProductDetailsService
    {
        ProductDetails GetProductDetail(int id);
    }
}
