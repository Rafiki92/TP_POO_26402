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
    public partial class AddBeneficiaryForm : Form
    { 
        private readonly BeneficiaryController beneficiaryController;
        public AddBeneficiaryForm(BeneficiaryController beneficiaryController)
        {
            InitializeComponent();
            this.beneficiaryController = beneficiaryController;
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Now;
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.Checked = false;
        }
        

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
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

                MessageBox.Show("Beneficiary added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the form
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding beneficiary: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
