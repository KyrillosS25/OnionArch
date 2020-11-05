using DataAccess.Entities;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Service
{
    public class ProductService : IProductService
    {
        private IRepository<Product> productRepository;
        private IRepository<ProductDetails> productDetailRepository;

        public ProductService(IRepository<Product> productRepository, IRepository<ProductDetails> productDetailRepository)
        {
            this.productRepository = productRepository;
            this.productDetailRepository = productDetailRepository;
        }
        public IQueryable<Product> GetProduct()
        {
            return productRepository.GetAll();
        }

        public Product GetProduct(int id)
        {
            return productRepository.Get(id);
        }
    }
}
