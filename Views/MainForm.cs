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
using ThriftShopApp.Models;
using ThriftShopApp.Services;

namespace ThriftShopApp.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //private void addNewBeneficiaryMenuItem_Click(object sender, EventArgs e)
        //{
          //  var addBeneficiaryForm = new AddBeneficiaryForm(new BeneficiaryController(new Beneficiaries()));
            //addBeneficiaryForm.ShowDialog();

        //}

        private void viewAllBeneficiariesMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewBeneficiaryMenuItem_Click_1(object sender, EventArgs e)
        {
            var addBeneficiaryForm = new AddBeneficiaryForm(new BeneficiaryController(new Beneficiaries()));
            addBeneficiaryForm.ShowDialog();

        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var productsService = new Products();
            var productListForm = new ProductListForm(productsService);
            productListForm.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                    "Tem a certeza de que quer sair?",
                    "Confirme Saída",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit(); // Closes the application

            }
        }

        private void verBeneficiáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var beneficiariesService = new Beneficiaries();
            

            // Create and show the BeneficiaryListForm
            var beneficiaryListForm = new BeneficiaryListForm(beneficiariesService);
            beneficiaryListForm.ShowDialog(); // Opens the form modally
        }

        private void adicionarNovoDoadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance of the Donors service and the DonorController
            var donorController = new DonorController(new Donors());

            // Open the AddDonorForm
            var addDonorForm = new AddDonorForm(donorController);
            addDonorForm.ShowDialog(); // Opens the form modally
        }
    }
}
