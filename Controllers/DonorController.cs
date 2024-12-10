using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThriftShopApp.Models;
using ThriftShopApp.Services;

namespace ThriftShopApp.Controllers
{
    public class DonorController
    {
        private readonly Donors donorsService;

        public DonorController(Donors donorsService)
        {
            this.donorsService = donorsService;
        }

        // Add a new donor
        public void AddDonor(int id, string name, int contactNumber, DateTime startDate, DateTime? endDate)
        {
            var newDonor = new Donor(id, name, contactNumber, startDate, endDate);
            donorsService.AddDonor(newDonor);
        }

        // Update an existing donor
        public bool UpdateDonor(int id, string name, int contactNumber, DateTime startDate, DateTime? endDate)
        {
            return donorsService.UpdateDonor(id, name, contactNumber, startDate, endDate);
        }

        // Inactivate a donor
        public bool InactivateDonor(int id)
        {
            return donorsService.InactivateDonor(id);
        }

        // Get all donors
        public List<Donor> GetAllDonors()
        {
            return donorsService.GetAllDonors();
        }

        // Get donor by ID
        public Donor GetDonorById(int id)
        {
            var donors = donorsService.GetAllDonors();
            return donors.Find(d => d.DonorID == id);
        }
    }
}
