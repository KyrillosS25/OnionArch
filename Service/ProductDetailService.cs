using DataAccess.Entities;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class ProductDetailsService : IProductDetailsService
    {
        private IRepository<ProductDetails> productDetailsRepository;

        public ProductDetailsService(IRepository<ProductDetails> productDetailsRepository)
        {
            this.productDetailsRepository = productDetailsRepository;
        }

        public ProductDetails GetProductDetail(int id)
        {
            return productDetailsRepository.Get(id);
        }
    }
}
