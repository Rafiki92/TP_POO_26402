using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThriftShopApp.Models;
using ThriftShopApp.Services;

namespace ThriftShopApp.Controllers
{
    public class ProductController
    {
        private readonly Products productsService;

        public ProductController(Products productsService)
        {
            this.productsService = productsService;
        }

        // Add a new product
        public void AddProduct(int id, string name, string category, string description, int quantity, string status)
        {
            var newProduct = new Product(id, name, category, description, quantity, status);
            productsService.AddProduct(newProduct);
        }

        // Update an existing product
        public bool UpdateProduct(int id, string name, string category, string description, int quantity, string status)
        {
            return productsService.UpdateProduct(id, name, category, description, quantity, status);
        }

        // Get a list of all products
        public List<Product> GetAllProducts()
        {
            return productsService.GetAllProducts();
        }

        // Get a product by its ID
        public Product GetProductById(int id)
        {
            var products = productsService.GetAllProducts();
            return products.Find(p => p.ProductID == id);
        }
    }
}
