﻿using Utility_001.Data;

namespace Utility_001.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }

        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        /*  public Product GetProductById(int id)
          {
              return _productRepository.GetProductById(id);
          }

          public void AddProduct(Product product)
          {
              _productRepository.AddProduct(product);
          }

          public void UpdateProduct(Product product)
          {
              _productRepository.UpdateProduct(product);
          }

          public void DeleteProduct(int id)
          {
              _productRepository.DeleteProduct(id);
          }*/
    }
}
