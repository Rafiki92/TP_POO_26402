using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThriftShopApp.Processes;
using ThriftShopApp.Registers;
using ThriftShopApp.Users;
using ThriftShopApp.Clients;
using ThriftShopApp.Logins;
using ThriftShopApp.Products;
using ThriftShopApp.Timetables;

namespace ThriftShopApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Volunteer volunteer1 = new Volunteer(1, "Alice Brown", DateTime.Now.AddYears(-2), DateTime.Now, 123456789, "123 Main St", "alice", "password1", 120.0f);
            Volunteer volunteer2 = new Volunteer(2, "Bob Smith", DateTime.Now.AddYears(-1), DateTime.Now, 987654321, "456 Oak St", "bob", "password2", 150.0f);

            // Create some timetable instances
            Timetable timetable1 = new Timetable(1, DateTime.Now, DateTime.Now.AddHours(2), "Morning Shift", 4.0f);
            Timetable timetable2 = new Timetable(2, DateTime.Now.AddDays(1), DateTime.Now.AddHours(3), "Evening Shift", 3.5f);

            // Create and add timetable registrations
            TimetableReg reg1 = new TimetableReg(1, volunteer1, timetable1);
            TimetableReg reg2 = new TimetableReg(2, volunteer2, timetable2);

            // Display all timetable registrations
            TimetableReg.DisplayAllTimetableRegistrations();

            // Display registrations for a specific volunteer
            TimetableReg.DisplayRegistrationsByVolunteer(volunteer1);

            // Pause the console to view output
            Console.ReadLine();
        }

    }
    }