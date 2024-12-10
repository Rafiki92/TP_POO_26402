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
    public partial class LoginForm : Form
    {
        private readonly AuthController authController;
        public LoginForm(AuthController authController)
        {
            InitializeComponent();
            this.authController = authController;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Input validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, coloque Username e Password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Authenticate the user
                var user = authController.Login(username, password);

                // If successful, show a success message
                MessageBox.Show($"Bem-vindo, {user.Name}!", "Login Bem Sucedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Navigate to the MainForm
                var mainForm = new MainForm();
                mainForm.Show();

                // Hide the LoginForm
                this.Hide();
            }
            catch (UnauthorizedAccessException ex)
            {
                // If authentication fails, show an error message
                MessageBox.Show(ex.Message, "Login Falhou", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

            private void Exit_Click(object sender, EventArgs e)
            {
                // Confirm before exiting the application
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
        }
    }
