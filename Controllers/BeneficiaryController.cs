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
    /// Handles operations related to beneficiaries in the thrift shop application.
    /// Acts as a bridge between the UI/clients and the Beneficiaries service layer.
    /// </summary>
    public class BeneficiaryController
    {
        // Instance of the Beneficiaries manager/service.
        private readonly IBeneficiaries beneficiariesService;

        /// <summary>
        /// Initializes a new instance of the <see cref="BeneficiaryController"/> class with a specified Beneficiaries service.
        /// </summary>
        /// <param name="beneficiariesService">The service to manage beneficiary operations.</param>
        public BeneficiaryController(IBeneficiaries beneficiariesService)
        {
            this.beneficiariesService = beneficiariesService;
        }

        /// <summary>
        /// Adds a new beneficiary to the system.
        /// </summary>
        /// <param name="id">The unique ID of the beneficiary.</param>
        /// <param name="name">The name of the beneficiary.</param>
        /// <param name="phoneNumber">The contact number of the beneficiary.</param>
        /// <param name="reference">The reference for the beneficiary.</param>
        /// <param name="familyNumber">The family number associated with the beneficiary.</param>
        /// <param name="hasChildren">Indicates whether the beneficiary has children.</param>
        /// <param name="notes">Additional notes for the beneficiary.</param>
        /// <param name="nationality">The nationality of the beneficiary.</param>
        /// <param name="startDate">The date the beneficiary started.</param>
        /// <param name="endDate">The end date for the beneficiary, if applicable.</param>
        public void AddBeneficiary(int id, string name, int phoneNumber, string reference, int familyNumber,
            bool hasChildren, string notes, string nationality, DateTime startDate, DateTime? endDate)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name), "O Nome não pode ser campo vazio ou nulo.");
            }
            // Create a new Beneficiary object.
            var newBeneficiary = new Beneficiary(id, name, phoneNumber, reference, familyNumber, hasChildren, notes, nationality, startDate, endDate);

            // Delegate the addition to the Beneficiaries service.
            beneficiariesService.AddBeneficiary(newBeneficiary);
        }

        /// <summary>
        /// Updates the details of an existing beneficiary.
        /// </summary>
        /// <param name="id">The unique ID of the beneficiary.</param>
        /// <param name="name">The new name of the beneficiary.</param>
        /// <param name="phoneNumber">The new contact number of the beneficiary.</param>
        /// <param name="reference">The new reference for the beneficiary.</param>
        /// <param name="familyNumber">The updated family number.</param>
        /// <param name="hasChildren">Indicates whether the beneficiary has children.</param>
        /// <param name="notes">Additional notes for the beneficiary.</param>
        /// <param name="nationality">The updated nationality.</param>
        /// <param name="startDate">The new start date for the beneficiary.</param>
        /// <param name="endDate">The new end date for the beneficiary, if applicable.</param>
        /// <returns>True if the beneficiary was updated successfully; otherwise, false.</returns>
        public bool UpdateBeneficiary(int id, string name, int phoneNumber, string reference, int familyNumber,
            bool hasChildren, string notes, string nationality, DateTime startDate, DateTime? endDate)
        {
            // Delegate the update operation to the Beneficiaries service.
            return beneficiariesService.UpdateBeneficiary(id, name, phoneNumber, reference, familyNumber, hasChildren, notes, nationality, startDate, endDate);
        }

        /// <summary>
        /// Marks a beneficiary as inactive.
        /// </summary>
        /// <param name="id">The unique ID of the beneficiary to inactivate.</param>
        /// <returns>True if the beneficiary was inactivated successfully; otherwise, false.</returns>
        public bool InactivateBeneficiary(int id)
        {
            // Delegate the inactivation to the Beneficiaries service.
            return beneficiariesService.InactivateBeneficiary(id);
        }

        /// <summary>
        /// Retrieves all beneficiaries in the system.
        /// </summary>
        /// <returns>A list of all <see cref="Beneficiary"/> objects.</returns>
        public List<Beneficiary> GetAllBeneficiaries()
        {
            // Fetch all beneficiaries from the service.
            return beneficiariesService.GetAll();
        }

        /// <summary>
        /// Retrieves a specific beneficiary by their unique ID.
        /// </summary>
        /// <param name="id">The ID of the beneficiary to retrieve.</param>
        /// <returns>The <see cref="Beneficiary"/> object if found; otherwise, null.</returns>
        public Beneficiary GetBeneficiaryById(int id)
        {
            // Search for the beneficiary by ID in the collection.
            var beneficiaries = beneficiariesService.GetAll();
            return beneficiaries.Find(b => b.BenID == id);
        }

        /// <summary>
        /// Retrieves all active beneficiaries in the system.
        /// </summary>
        /// <returns>A list of all active <see cref="Beneficiary"/> objects.</returns>
        public List<Beneficiary> GetActiveBeneficiaries()
        {
            // Filter the collection to include only active beneficiaries.
            var beneficiaries = beneficiariesService.GetAll();
            return beneficiaries.FindAll(b => b.IsActive());
        }
    }
}

