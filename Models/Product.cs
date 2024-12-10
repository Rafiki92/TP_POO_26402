using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ThriftShopApp.Models
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
        public Product(int productID, string name, string category, string description, int quantity, string status)
        {
            this.ProductID = productID;
            this.Name = name;
            this.Category = category;
            this.Description = description;
            this.Quantity = quantity;
            this.Status = status;
        }
        #endregion

        #region Methods
        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product ID: {ProductID}, Name: {Name}, Category: {Category}, Description: {Description}, Quantity: {Quantity}, Status: {Status}");
        }

        #endregion
    }
}
