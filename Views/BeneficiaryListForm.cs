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
    /// Form to display a list of beneficiaries in the thrift shop system.
    /// Allows viewing and refreshing the list of beneficiaries.
    /// </summary>
    public partial class BeneficiaryListForm : Form
    {
        // Reference to the BeneficiaryController for managing business logic.
        private readonly BeneficiaryController controller;

        /// <summary>
        /// Initializes a new instance of the <see cref="BeneficiaryListForm"/> class.
        /// </summary>
        /// <param name="beneficiaresService">The service managing beneficiary data.</param>
        public BeneficiaryListForm(Beneficiaries beneficiaresService)
        {
            InitializeComponent();
            controller = new BeneficiaryController(beneficiaresService);
            LoadBeneficiaries();
        }

        /// <summary>
        /// Loads the list of beneficiaries from the controller and binds it to the grid view.
        /// </summary>
        private void LoadBeneficiaries()
        {
            try
            {
                var beneficiaries = controller.GetAllBeneficiaries();
                beneficiaryGridView.DataSource = null; // Clear existing data binding
                beneficiaryGridView.DataSource = beneficiaries; // Bind new data
            }
            // Display an error message if fetching beneficiaries fails.
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading beneficiaries: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the Click event for the Refresh button.
        /// Reloads the list of beneficiaries.
        /// </summary>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBeneficiaries();
        }
    }
}
