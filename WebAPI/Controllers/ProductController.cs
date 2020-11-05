using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;
        private readonly IProductDetailsService productDetailsService;

        public ProductController(IProductService productService, IProductDetailsService productDetailsService)
        {
            this.productService = productService;
            this.productDetailsService = productDetailsService;
        }

        [HttpGet]
        public List<ProductDetails> Get()
        {
            List<ProductDetails> productDetails = new List<ProductDetails>();
            var prodcutList = productService.GetProduct().ToList();
            foreach (var product in prodcutList)
            {
                var productDetailList = productDetailsService.GetProductDetail(product.ProductId);
                ProductDetails details = new ProductDetails
                {
                    ProductId = product.ProductId,
                    ProductName = product.ProductName,
                    Price = productDetailList.Price,
                    StockAvailable = productDetailList.StockAvailable,
                };
                productDetails.Add(details);
            }
            return productDetails;
        }
    }
}
