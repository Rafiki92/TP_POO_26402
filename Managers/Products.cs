using System;
using System.Collections.Generic;
using System.Linq;
using ThriftShopApp.Models;

namespace ThriftShopApp.Managers
{
    /// <summary>
    /// Manages the inventory of products for the thrift shop application.
    /// Provides functionality to add, update, remove, and display products.
    /// </summary>
    public class Products
    {
        // List to store Product objects.
        private readonly List<Product> products = new List<Product>();

        #region Methods

        /// <summary>
        /// Adds a new product to the inventory.
        /// </summary>
        /// <param name="product">The product object to add.</param>
        public void AddProduct(Product product)
        {
            // Ensure the product object is not null.
            if (product == null)
                throw new ArgumentNullException(nameof(product), "Product cannot be null.");

            // Add the product to the inventory.
            products.Add(product);

            // Inform the user about the successful addition.
            Console.WriteLine($"Product '{product.Name}' added successfully.");
        }

        /// <summary>
        /// Updates the details of an existing product.
        /// </summary>
        /// <param name="productID">The ID of the product to update.</param>
        /// <param name="newName">The new name of the product.</param>
        /// <param name="newCategory">The new category of the product.</param>
        /// <param name="newDescription">The new description of the product.</param>
        /// <param name="newQuantity">The updated quantity of the product.</param>
        /// <param name="newStatus">The new status of the product (e.g., "Available", "Unavailable").</param>
        /// <returns>True if the product was updated successfully; otherwise, false.</returns>
        public bool UpdateProduct(int productID, string newName, string newCategory, string newDescription, int newQuantity, string newStatus)
        {
            // Find the product by its ID.
            var product = products.FirstOrDefault(p => p.ProductID == productID);
            if (product == null)
                return false;

            // Update the product's details with the provided values.
            product.Name = newName;
            product.Category = newCategory;
            product.Description = newDescription;
            product.Quantity = newQuantity;
            product.Status = newStatus;

            // Inform the user about the successful update.
            Console.WriteLine($"Product with ID {productID} updated successfully.");
            return true;
        }

        /// <summary>
        /// Removes a product from the inventory by its unique ID.
        /// </summary>
        /// <param name="productID">The ID of the product to remove.</param>
        /// <returns>True if the product was removed successfully; otherwise, false.</returns>
        public bool RemoveProductByID(int productID)
        {
            // Find the product by its ID.
            var product = products.FirstOrDefault(p => p.ProductID == productID);

            if (product != null)
            {
                // Remove the product from the inventory.
                products.Remove(product);

                // Inform the user about the successful removal.
                Console.WriteLine($"Product with ID {productID} removed successfully.");
                return true;
            }

            // Inform the user if the product was not found.
            Console.WriteLine($"Product with ID {productID} not found.");
            return false;
        }

        /// <summary>
        /// Displays all products in the inventory along with their details.
        /// </summary>
        public void DisplayAllProducts()
        {
            // Display the total number of products.
            Console.WriteLine($"Total Number of Products: {products.Count}");

            // Loop through and display each product's details.
            foreach (var product in products)
            {
                // Assuming the Product class has a method to display its details.
                product.DisplayProductDetails();
            }
        }

        /// <summary>
        /// Retrieves the list of all products in the inventory.
        /// </summary>
        /// <returns>A list of all product objects.</returns>
        public List<Product> GetAllProducts()
        {
            // Return the internal list of products.
            return products;
        }

        #endregion
    }
}

