using NUnit.Framework;
using Moq;
using ThriftShopApp.Controllers;
using ThriftShopApp.Managers;
using ThriftShopApp.Models;
using System;

namespace ThriftShopApp.Tests
{
    /// <summary>
    /// Unit tests for the BeneficiaryController class.
    /// </summary>
    [TestFixture]
    public class BeneficiaryControllerTests
    {
        private Mock<IBeneficiaries> _mockBeneficiaries; // Mock for the IBeneficiaries interface.
        private BeneficiaryController _controller; // The controller under test.

        /// <summary>
        /// Sets up the test environment before each test.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            // Initialize the mock for IBeneficiaries.
            _mockBeneficiaries = new Mock<IBeneficiaries>();

            // Inject the mock into the BeneficiaryController.
            _controller = new BeneficiaryController(_mockBeneficiaries.Object);
        }

        /// <summary>
        /// Verifies that AddBeneficiary calls the AddBeneficiary method on the IBeneficiaries service with the correct parameters.
        /// </summary>
        [Test]
        public void AddBeneficiary_ValidInput_CallsAddBeneficiaryOnService()
        {
            // Arrange: Create a sample Beneficiary object.
            var beneficiary = new Beneficiary(
                benID: 1,
                name: "John Doe",
                phoneNumber: 123456789,
                reference: "Ref",
                familyNumber: 3,
                hasChildren: true,
                notes: "Test Notes",
                nationality: "Test Country",
                startDate: DateTime.Now,
                endDate: null
            );

            // Act: Call AddBeneficiary on the controller.
            _controller.AddBeneficiary(
                id: beneficiary.BenID,
                name: beneficiary.Name,
                phoneNumber: beneficiary.PhoneNumber,
                reference: beneficiary.Reference,
                familyNumber: beneficiary.FamilyNumber,
                hasChildren: beneficiary.HasChildren,
                notes: beneficiary.Notes,
                nationality: beneficiary.Nationality,
                startDate: beneficiary.StartDate,
                endDate: beneficiary.EndDate
            );

            // Assert: Verify that AddBeneficiary was called on the mock with the correct object.
            _mockBeneficiaries.Verify(b => b.AddBeneficiary(It.Is<Beneficiary>(ben =>
                ben.BenID == beneficiary.BenID &&
                ben.Name == beneficiary.Name &&
                ben.PhoneNumber == beneficiary.PhoneNumber &&
                ben.Reference == beneficiary.Reference &&
                ben.FamilyNumber == beneficiary.FamilyNumber &&
                ben.HasChildren == beneficiary.HasChildren &&
                ben.Notes == beneficiary.Notes &&
                ben.Nationality == beneficiary.Nationality &&
                ben.StartDate == beneficiary.StartDate &&
                ben.EndDate == beneficiary.EndDate
            )), Times.Once); // Ensure it's called exactly once.
        }

        /// <summary>
        /// Verifies that an exception is thrown when AddBeneficiary is called with invalid data.
        /// </summary>
        [Test]
        public void AddBeneficiary_NullName_ThrowsArgumentNullException()
        {
            // Act & Assert: Expect an ArgumentNullException when the name is null.
            var ex = Assert.Throws<ArgumentNullException>(() => _controller.AddBeneficiary(
                id: 1,
                name: null, // Invalid input.
                phoneNumber: 123456789,
                reference: "Ref",
                familyNumber: 3,
                hasChildren: true,
                notes: "Test Notes",
                nationality: "Test Country",
                startDate: DateTime.Now,
                endDate: null
            ));

            // Assert: Verify the exception message.
            Assert.That(ex.Message, Does.Contain("O Nome não pode ser campo vazio ou nulo"));
        }
    }
}
