using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThriftShopApp.Models;
using ThriftShopApp.Managers;

namespace ThriftShopApp.Controllers
{
    /// <summary>
    /// Handles operations related to donors in the thrift shop application.
    /// Acts as a bridge between the UI/clients and the Donors service layer.
    /// </summary>
    public class DonorController
    {
        // Instance of the Donors service for managing donor operations.
        private readonly Donors donorsService;

        /// <summary>
        /// Initializes a new instance of the <see cref="DonorController"/> class with a specified Donors service.
        /// </summary>
        /// <param name="donorsService">The service to manage donor operations.</param>
        public DonorController(Donors donorsService)
        {
            this.donorsService = donorsService;
        }

        /// <summary>
        /// Adds a new donor to the system.
        /// </summary>
        /// <param name="id">The unique ID of the donor.</param>
        /// <param name="name">The name of the donor.</param>
        /// <param name="contactNumber">The contact number of the donor.</param>
        /// <param name="startDate">The date the donor started.</param>
        /// <param name="endDate">The end date for the donor, if applicable.</param>
        public void AddDonor(int id, string name, int contactNumber, DateTime startDate, DateTime? endDate)
        {
            // Create a new Donor object.
            var newDonor = new Donor(id, name, contactNumber, startDate, endDate);

            // Delegate the addition to the Donors service.
            donorsService.AddDonor(newDonor);
        }

        /// <summary>
        /// Updates the details of an existing donor.
        /// </summary>
        /// <param name="id">The unique ID of the donor.</param>
        /// <param name="name">The updated name of the donor.</param>
        /// <param name="contactNumber">The updated contact number of the donor.</param>
        /// <param name="startDate">The updated start date of the donor.</param>
        /// <param name="endDate">The updated end date for the donor, if applicable.</param>
        /// <returns>True if the donor was updated successfully; otherwise, false.</returns>
        public bool UpdateDonor(int id, string name, int contactNumber, DateTime startDate, DateTime? endDate)
        {
            // Delegate the update operation to the Donors service.
            return donorsService.UpdateDonor(id, name, contactNumber, startDate, endDate);
        }

        /// <summary>
        /// Marks a donor as inactive.
        /// </summary>
        /// <param name="id">The unique ID of the donor to inactivate.</param>
        /// <returns>True if the donor was inactivated successfully; otherwise, false.</returns>
        public bool InactivateDonor(int id)
        {
            // Delegate the inactivation to the Donors service.
            return donorsService.InactivateDonor(id);
        }

        /// <summary>
        /// Retrieves all donors in the system.
        /// </summary>
        /// <returns>A list of all <see cref="Donor"/> objects.</returns>
        public List<Donor> GetAllDonors()
        {
            // Fetch all donors from the service.
            return donorsService.GetAllDonors();
        }

        /// <summary>
        /// Retrieves a specific donor by their unique ID.
        /// </summary>
        /// <param name="id">The ID of the donor to retrieve.</param>
        /// <returns>The <see cref="Donor"/> object if found; otherwise, null.</returns>
        public Donor GetDonorById(int id)
        {
            // Search for the donor by ID in the collection.
            var donors = donorsService.GetAllDonors();
            return donors.Find(d => d.DonorID == id);
        }
    }
}

