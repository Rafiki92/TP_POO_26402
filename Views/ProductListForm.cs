using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThriftShopApp.Controllers;
using ThriftShopApp.Managers;

namespace ThriftShopApp.Views
{
    /// <summary>
    /// Form to display a list of products in the thrift shop system.
    /// Provides functionality to view and refresh the list of products.
    /// </summary>
    public partial class ProductListForm : Form
    {
        // Reference to the ProductController for managing business logic.
        private readonly ProductController controller;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductListForm"/> class.
        /// </summary>
        /// <param name="productsService">The service managing product data.</param>
        public ProductListForm(Products productsService)
        {
            InitializeComponent();
            controller = new ProductController(productsService);
            LoadProducts();
        }

        /// <summary>
        /// Loads the list of products from the controller and binds it to the grid view.
        /// </summary>
        private void LoadProducts()
        {
            try
            {
                var products = controller.GetAllProducts();
                productGridView.DataSource = null; // Clear existing data binding
                productGridView.DataSource = products; // Bind new data
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the Click event for the Refresh button.
        /// Reloads the list of products.
        /// </summary>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}
