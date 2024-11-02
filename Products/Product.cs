using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThriftShop.Actors;

namespace ThriftShop.Products
{
    /// <summary>
    /// 
    /// </summary>
    public class Product
    {
        #region Attributes
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public Category Category { get; set; }

        private static List<Product> products = new List<Product>();
        #endregion

        #region Constructors
        public Product(int productId, string name, Category category, int quantity)
        {
            this.ProductId = productId;
            this.Name = name;
            this.Category = category ?? throw new ArgumentNullException(nameof(category));
            this.Quantity = quantity;
        }
        #endregion

        #region Methods
        public static void AddProduct(Product product)
        {
            products.Add(product);
        }

        public static void DisplayProducts()
        {
            Console.WriteLine("Products:");
            // Loop through each product in the products list
            foreach (var product in products)
            {
                // Display the product's details
                Console.WriteLine($"ID: {product.ProductId}, Name: {product.Name}, Quantity: {product.Quantity}, Category: {product.Category.Name}");
            }
        }
        #endregion
    }
}
