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
    public partial class AddDonorForm : Form
    {
        private readonly DonorController controller;
        public AddDonorForm(DonorController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

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

                controller.AddDonor(id, name, contactNumber, startDate, endDate);
                MessageBox.Show("Donor added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding donor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkEndDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpEndDate.Enabled = chkEndDate.Checked;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
