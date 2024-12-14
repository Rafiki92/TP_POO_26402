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

namespace ThriftShopApp.Views
{
    /// <summary>
    /// Form for adding a new donor to the thrift shop system.
    /// </summary>
    public partial class AddDonorForm : Form
    {
        // Reference to the DonorController to handle business logic.
        private readonly DonorController controller;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddDonorForm"/> class.
        /// </summary>
        /// <param name="controller">The controller to manage donor operations.</param>
        public AddDonorForm(DonorController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        /// <summary>
        /// Handles the Click event for the Add button.
        /// Collects form inputs, validates them, and sends the data to the controller to add a new donor.
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtDonorID.Text);
                string name = txtName.Text;
                int contactNumber = int.Parse(txtContactNumber.Text);
                DateTime startDate = dtpStartDate.Value;

                // Validate end date
                DateTime? endDate = null;
                if (chkEndDate != null && chkEndDate.Checked)
                {
                    if (dtpEndDate != null)
                    {
                        endDate = dtpEndDate.Value;
                    }
                }

                // Add the donor through the controller.
                controller.AddDonor(id, name, contactNumber, startDate, endDate);
                MessageBox.Show("Donor added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            // Handle unexpected errors.
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding donor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the CheckedChanged event for the End Date checkbox.
        /// Enables or disables the End Date picker based on the checkbox state.
        /// </summary>
        private void chkEndDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpEndDate.Enabled = chkEndDate.Checked;
        }

        /// <summary>
        /// Handles the Click event for the Cancel button.
        /// Closes the form without making any changes.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
