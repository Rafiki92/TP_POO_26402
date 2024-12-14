using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThriftShopApp.Models;
using ThriftShopApp.Managers;

namespace ThriftShopApp.Controllers
{
    /// <summary>
    /// Handles operations related to products in the thrift shop application.
    /// Acts as a bridge between the UI/clients and the Products service layer.
    /// </summary>
    public class ProductController
    {
        // Instance of the Products service for managing product operations.
        private readonly Products productsService;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductController"/> class with a specified Products service.
        /// </summary>
        /// <param name="productsService">The service to manage product operations.</param>
        public ProductController(Products productsService)
        {
            this.productsService = productsService;
        }

        /// <summary>
        /// Adds a new product to the system.
        /// </summary>
        /// <param name="id">The unique ID of the product.</param>
        /// <param name="name">The name of the product.</param>
        /// <param name="category">The category of the product.</param>
        /// <param name="description">The description of the product.</param>
        /// <param name="quantity">The initial quantity of the product.</param>
        /// <param name="status">The status of the product (e.g., "Available", "Unavailable").</param>
        public void AddProduct(int id, string name, string category, string description, int quantity, string status)
        {
            // Create a new Product object.
            var newProduct = new Product(id, name, category, description, quantity, status);

            // Delegate the addition to the Products service.
            productsService.AddProduct(newProduct);
        }

        /// <summary>
        /// Updates the details of an existing product.
        /// </summary>
        /// <param name="id">The unique ID of the product.</param>
        /// <param name="name">The updated name of the product.</param>
        /// <param name="category">The updated category of the product.</param>
        /// <param name="description">The updated description of the product.</param>
        /// <param name="quantity">The updated quantity of the product.</param>
        /// <param name="status">The updated status of the product.</param>
        /// <returns>True if the product was updated successfully; otherwise, false.</returns>
        public bool UpdateProduct(int id, string name, string category, string description, int quantity, string status)
        {
            // Delegate the update operation to the Products service.
            return productsService.UpdateProduct(id, name, category, description, quantity, status);
        }

        /// <summary>
        /// Retrieves all products in the system.
        /// </summary>
        /// <returns>A list of all <see cref="Product"/> objects.</returns>
        public List<Product> GetAllProducts()
        {
            // Fetch all products from the service.
            return productsService.GetAllProducts();
        }

        /// <summary>
        /// Retrieves a specific product by its unique ID.
        /// </summary>
        /// <param name="id">The ID of the product to retrieve.</param>
        /// <returns>The <see cref="Product"/> object if found; otherwise, null.</returns>
        public Product GetProductById(int id)
        {
            // Search for the product by ID in the collection.
            var products = productsService.GetAllProducts();
            return products.Find(p => p.ProductID == id);
        }
    }
}

