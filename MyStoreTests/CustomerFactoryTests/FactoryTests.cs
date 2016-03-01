using System;
using CustomerFactory;
using CustomerInterface;
using CustomerLibrary;
using CustomerLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyStoreTests.CustomerLibraryTests;
using MyStoreTests.WindowsCustomerUITests;

namespace MyStoreTests.CustomerFactoryTests
{
    [TestClass]
    public class FactoryTests
    {
        public readonly string TestLeadType = CustomerScreenTests.TestCustomerTypes.Lead.ToString();
        public readonly string TestCustomerType = CustomerScreenTests.TestCustomerTypes.Customer.ToString();

        [TestMethod]
        public void CreatesNewLeadInstance()
        {
            //Arrange
            //Act
            var result = Factory<ICustomer>.Create(TestLeadType);
            //Assert
            var leadResult = result as Lead;
            Assert.IsNotNull(leadResult);
        }

        [TestMethod]
        public void CreatesNewCustomerInstance()
        {
            //Arrange
            //Act
            var result = Factory<ICustomer>.Create(TestCustomerType);
            //Assert
            var leadResult = result as Customer;
            Assert.IsNotNull(leadResult);
        }

        [TestMethod]
        public void CreatesFreshCloneofCustomerFromFactory()
        {
            //Arrange
            //Act
            var firstResult = Factory<ICustomer>.Create(TestCustomerType);
            var secondResult = Factory<ICustomer>.Create(TestCustomerType);
            //Assert
            Assert.AreNotSame(firstResult, secondResult);
        }
    }
}
