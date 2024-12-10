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
    public partial class BeneficiaryListForm : Form
    {
        private readonly BeneficiaryController controller;
        public BeneficiaryListForm(Beneficiaries beneficiaresService)
        {
            InitializeComponent();
            controller = new BeneficiaryController(beneficiaresService);
            LoadBeneficiaries();
        }
        private void LoadBeneficiaries()
        {
            try
            {
                var beneficiaries = controller.GetAllBeneficiaries();
                beneficiaryGridView.DataSource = null; // Clear existing data binding
                beneficiaryGridView.DataSource = beneficiaries; // Bind new data
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading beneficiaries: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBeneficiaries();
        }
    }
}
