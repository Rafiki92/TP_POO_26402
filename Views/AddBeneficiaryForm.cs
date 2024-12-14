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
    /// Form for adding a new beneficiary to the thrift shop system.
    /// </summary>
    public partial class AddBeneficiaryForm : Form
    {
        // Reference to the BeneficiaryController to handle business logic.
        private readonly BeneficiaryController beneficiaryController;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddBeneficiaryForm"/> class.
        /// </summary>
        /// <param name="beneficiaryController">The controller to manage beneficiary operations.</param>
        public AddBeneficiaryForm(BeneficiaryController beneficiaryController)
        {
            InitializeComponent();
            this.beneficiaryController = beneficiaryController;
        }

        /// <summary>
        /// Handles the ValueChanged event for the Start Date date picker.
        /// Sets the start date to the current date.
        /// </summary>
        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Now;
        }

        /// <summary>
        /// Handles the ValueChanged event for the End Date date picker.
        /// Unchecks the date picker to indicate no end date if modified.
        /// </summary>
        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.Checked = false;
        }

        /// <summary>
        /// Handles the Click event for the Add button.
        /// Collects form inputs, validates them, and sends the data to the controller to add a new beneficiary.
        /// </summary>
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Collect and parse form inputs.
                int id = int.Parse(txtID.Text);
                string name = txtName.Text;
                int phoneNumber = int.Parse(txtPhoneNumber.Text);
                string reference = txtReference.Text;
                int familyNumber = int.Parse(txtFamilyNumber.Text);
                bool hasChildren = chkHasChildren.Checked;
                string notes = txtNotes.Text;
                string nationality = txtNationality.Text;
                DateTime startDate = dtpStartDate.Value;
                DateTime? endDate = dtpEndDate.Checked ? dtpEndDate.Value : (DateTime?)null;

                // Add beneficiary through controller
                beneficiaryController.AddBeneficiary(id, name, phoneNumber, reference, familyNumber, hasChildren, notes, nationality, startDate, endDate);

                // Show success message and close the form.
                MessageBox.Show("Beneficiary added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the form
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding beneficiary: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the Click event for the Cancel button.
        /// Closes the form without making any changes.
        /// </summary>
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
