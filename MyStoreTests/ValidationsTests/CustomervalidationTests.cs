using System;
using CustomerLibrary;
using CustomerLibrary.Models;
using CustomerLibrary.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyStoreTests.CustomerLibraryTests;

namespace MyStoreTests.ValidationsTests
{
    [TestClass]
    public class CustomerValidationTests
    {
        [TestMethod]
        [ExpectedException(typeof(Exception), "Customer Name is required")]
        public void ThrowsExpectionOnCustomerNameLengthZero()
        {
            //Arrange
            var sut = new Customer(new CustomerValidation());
            //Act
            sut.Validate();
        }

        [TestMethod]
        public void DoesNotValidateBillAmountOnLead()
        {
            //Arrange
            var sut = new Lead(new LeadValidation()) { CustomerName = ModelTests.TestCustomerName, PhoneNumber = ModelTests.TestPhoneNumber };
            //Act
            sut.Validate();
            //Assert
            Assert.AreEqual(0m, sut.BillAmount);
        }
    }
}
