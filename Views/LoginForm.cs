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
using ThriftShopApp.Managers;


namespace ThriftShopApp.Views
{
    /// <summary>
    /// Login form for authenticating users in the thrift shop application.
    /// </summary>
    public partial class LoginForm : Form
    {
        // Reference to the AuthController for handling login logic.
        private readonly AuthController authController;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginForm"/> class.
        /// </summary>
        /// <param name="authController">The controller for managing authentication logic.</param>
        public LoginForm(AuthController authController)
        {
            InitializeComponent();
            this.authController = authController;
        }

        /// <summary>
        /// Handles the Click event for the Login button.
        /// Authenticates the user and navigates to the main application form if successful.
        /// </summary>
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

        /// <summary>
        /// Handles the Click event for the Exit button.
        /// Confirms the user's intent and exits the application if confirmed.
        /// </summary>
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
