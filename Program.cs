using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThriftShopApp.Models;
using ThriftShopApp.Managers;
using ThriftShopApp.Controllers;
using ThriftShopApp.Views;
using System.Windows.Forms;

namespace ThriftShopApp
{
    internal class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize services
            var adminsService = new Admins();
            var volunteersService = new Volunteers();

            adminsService.AddAdmin(new Admin(
                userId: 1,
                name: "Maria Rouxinol",
                startDate: DateTime.Now,
                endDate: null,
                contactNumber: 123456789,
                address: "123 Admin Street",
                username: "maria1",
                password: "password123",
                department: "Kids"));

            volunteersService.AddVolunteer(new Volunteer(
                userId: 2,
                name: "Miguel Rouco",
                startDate: new DateTime(2022,1,2),
                endDate: DateTime.Now,
                contactNumber: 987654321,
                address: "456 Volunteer Avenue",
                username: "miguel1",
                password: "123456789",
                volunteerHours: 0));

            // Initialize LoginService and AuthController
            var loginService = new LoginService(adminsService, volunteersService);
            var authController = new AuthController(loginService);

            // Start the application with the LoginForm
            Application.Run(new LoginForm(authController));

        }

    }
    }