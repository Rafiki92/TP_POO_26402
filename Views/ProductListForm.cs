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
using ThriftShopApp.Services;

namespace ThriftShopApp.Views
{
    public partial class ProductListForm : Form
    {
        private readonly ProductController controller;
        public ProductListForm(Products productsService)
        {
            InitializeComponent();
            controller = new ProductController(productsService);
            LoadProducts();
        }

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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}
