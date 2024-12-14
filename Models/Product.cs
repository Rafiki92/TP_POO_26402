using System;

namespace ThriftShopApp.Models
{
    /// <summary>
    /// Represents a product in the thrift shop application.
    /// Stores details such as the product's ID, name, category, description, quantity, and status.
    /// </summary>
    public class Product
    {
        #region Attributes
        // Unique identifier for the product.
        private int productID;

        // Name of the product.
        private string name;

        // Category to which the product belongs (e.g., "Clothing", "Electronics").
        private string category;

        // Description of the product.
        private string description;

        // Quantity of the product available in the inventory.
        private int quantity;

        // Current status of the product (e.g., "Available", "Out of Stock").
        private string status;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the unique ID of the product.
        /// </summary>
        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        /// <summary>
        /// Gets or sets the name of the product.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Gets or sets the category of the product.
        /// </summary>
        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        /// <summary>
        /// Gets or sets the description of the product.
        /// </summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        /// <summary>
        /// Gets or sets the quantity of the product available in the inventory.
        /// </summary>
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        /// <summary>
        /// Gets or sets the current status of the product (e.g., "Available", "Out of Stock").
        /// </summary>
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        /// <param name="productID">The unique ID of the product.</param>
        /// <param name="name">The name of the product.</param>
        /// <param name="category">The category of the product.</param>
        /// <param name="description">The description of the product.</param>
        /// <param name="quantity">The quantity of the product available in the inventory.</param>
        /// <param name="status">The current status of the product.</param>
        public Product(int productID, string name, string category, string description, int quantity, string status)
        {
            this.ProductID = productID;
            this.Name = name;
            this.Category = category;
            this.Description = description;
            this.Quantity = quantity > 0 ? quantity : throw new ArgumentOutOfRangeException(nameof(quantity), "Quantity must be greater than or equal to zero.");
            this.Status = !string.IsNullOrEmpty(status) ? status : throw new ArgumentNullException(nameof(status), "Status cannot be null or empty.");
        }
        #endregion

        #region Methods
        /// <summary>
        /// Displays the details of the product.
        /// </summary>
        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product ID: {ProductID}, Name: {Name}, Category: {Category}, Description: {Description}, Quantity: {Quantity}, Status: {Status}");
        }
        #endregion
    }
}

