using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThriftShopApp.Products
{
    /// <summary>
    /// 
    /// </summary>
    public class Products
    {
        private readonly List<Product> products = new List<Product>();

        #region Methods
        public void AddProduct(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product), "Product cannot be null.");

            products.Add(product);
            Console.WriteLine($"Product '{product.Name}' added successfully.");
        }

        public bool UpdateProduct(int productID, string newName, string newCategory, string newDescription, int newQuantity, string newStatus)
        {
            var product = products.FirstOrDefault(p => p.ProductID == productID);
            if (product == null)
                return false;

            product.Name = newName;
            product.Category = newCategory;
            product.Description = newDescription;
            product.Quantity = newQuantity;
            product.Status = newStatus;

            Console.WriteLine($"Product with ID {productID} updated successfully.");
            return true;
        }

        public bool RemoveProductByID(int productID)
        {
            var product = products.FirstOrDefault(p => p.ProductID == productID);
            if (product != null)
            {
                products.Remove(product);
                Console.WriteLine($"Product with ID {productID} removed successfully.");
                return true;
            }

            Console.WriteLine($"Product with ID {productID} not found.");
            return false;
        }

        public void DisplayAllProducts()
        {
            Console.WriteLine($"Total Number of Products: {products.Count}");
            foreach (var product in products)
            {
                product.DisplayProductDetails();
            }
        }

        #endregion
    }
}
