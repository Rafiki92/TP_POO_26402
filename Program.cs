using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThriftShop.Actors;
using ThriftShop.Products;

namespace ThriftShop
{

    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Product p1 = new Product(1, "Bicycle", "Sports", 1, null);
            Console.WriteLine($"Product Name: {p1.Name},\n Category: {p1.Category},\n Quantity: {p1.Quantity},\n Donor: {p1.Donor}");

            Volunteer v1 = new Volunteer (1, "Rafiki", "Char1", "Rafael Ferreira", "900", DateTime.Now, 0);
            Console.WriteLine($"Volunteer Details:\n" +
                  $"UserId: {v1.UserId}\n" +
                  $"Username: {v1.Username}\n" +
                  $"Password: {v1.Password}\n" +
                  $"Role: {v1.Role}\n" +
                  $"Name: {v1.Name}\n" +
                  $"Contact Info: {v1.ContactInfo}\n" +
                  $"Join Date: {v1.JoinDate.ToShortDateString()}\n" +
                  $"Hours Worked: {v1.HoursWorked}");
            Console.ReadLine();
        }
    }
}
