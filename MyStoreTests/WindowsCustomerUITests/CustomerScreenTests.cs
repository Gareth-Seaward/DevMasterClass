using System;
using WindowsCustomerUI;
using CustomerFactory;
using CustomerFactory.Fakes;
using CustomerInterface;
using CustomerLibrary;
using CustomerLibrary.Models;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyStoreTests.CustomerLibraryTests;

namespace MyStoreTests.WindowsCustomerUITests
{
    [TestClass]
    public class CustomerScreenTests
    {
        public enum TestCustomerTypes { Lead = 0, Customer = 1}

        //private Mock<Factory> _mockFactory;

        //[TestInitialize]
        //public void Setup()
        //{
        //    _mockFactory = new Mock<Factory>();
        //    _mockFactory.Setup(f => f.Create((int) TestCustomerTypes.Lead)).Returns(new Lead());
        //    _mockFactory.Setup(f => f.Create((int) TestCustomerTypes.Customer)).Returns(new Customer());
        //}

        [TestMethod]
        public void AddsnewCustomer()
        {
            //Arrange
            var todayTest = DateTime.Now;
            using (ShimsContext.Create())
            {
                //Arrange
                var sut = new FakeCustomerScreen();
                sut.SetupValues(TestCustomerTypes.Customer.ToString(), ModelTests.TestCustomerName, ModelTests.TestPhoneNumber,
                    ModelTests.TestAddress, ModelTests.TestBillAmount, todayTest);
                ShimFactory<ICustomer>.CreateString = custType => new Customer(null);
                //Act
                var result = sut.AddCustomer();
                //Assert
                var custResult = result as Customer;
                Assert.IsNotNull(custResult);
                Assert.AreEqual(ModelTests.TestCustomerName, custResult.CustomerName);
                Assert.AreEqual(ModelTests.TestPhoneNumber, custResult.PhoneNumber);
                Assert.AreEqual(ModelTests.TestAddress, custResult.Address);
                Assert.AreEqual(ModelTests.TestBillAmount, custResult.BillAmount);
                Assert.AreEqual(todayTest, custResult.BillDate);
            }
            
        }
    }

    public class FakeCustomerScreen : CustomerScreen
    {
        //public FakeCustomerScreen(Factory factory)
        //{
        //    Factory = factory;
        //}

        public void SetupValues(string customerType, string customerName, string phoneNumber, string address, decimal billAmount,
            DateTime billDate)
        {
            SelectedCustomerType = customerType;
            CustomerName = customerName;
            PhoneNumber = phoneNumber;
            Address = address;
            BillAmount = billAmount;
            BillDate = billDate;
        }
    }
}
