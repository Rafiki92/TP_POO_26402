using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThriftShopApp.Processes;

namespace ThriftShopApp.Products
{
    /// <summary>
    /// Represents a product of the thrift shop.
    /// </summary>
    public class Product
    {
        #region Attributes
        private int productID;
        private string name;
        private string category;
        private string description;
        private int quantity;
        private string status;

        private static List<Product> products = new List<Product>();
        #endregion

        #region Properties
        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        #endregion

        #region Constructors
        public Product(int productID, string name, string category, string description, int quantityAvailable, string status)
        {
            this.ProductID = productID;
            this.Name = name;
            this.Category = category;
            this.Description = description;
            this.Quantity = quantity;
            this.Status = status;
            
            products.Add(this);
        }
        #endregion

        #region Methods
        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product ID: {ProductID}, Name: {Name}, Category: {Category}, Description: {Description}, Quantity: {Quantity}, Status: {Status}");
        }

        public static void DisplayAllProducts()
        {
            Console.WriteLine("\nList of All Products:");
            foreach (var product in products)
            {
                product.DisplayProductDetails();
                Console.WriteLine();
            }
        }

        public static void AddProduct(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));
            products.Add(product);
            Console.WriteLine($"Product '{product.Name}' added successfully.");
        }
        #endregion
    }
}
