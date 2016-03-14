using System;
using CustomerLibrary;
using CustomerLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyStoreTests.CustomerLibraryTests
{
    [TestClass]
    public class ModelTests
    {
        public const string TestCustomerName = "TestCustomerName";
        public const string TestPhoneNumber = "TestNumber";
        public const decimal TestBillAmount = 500m;
        public DateTime TestBillDate;
        public const string TestAddress = "TestAddress";

        [TestInitialize]
        public void Setup()
        {
            TestBillDate = DateTime.Now;
        }

        [TestMethod]
        public void CreatesClassStructureForLeadModel()
        {
            //Arrange
            CustomerBase sut = new Lead(null);
            //Act
            sut.CustomerName = TestCustomerName;
            sut.PhoneNumber = TestPhoneNumber;
            sut.BillAmount = TestBillAmount;
            sut.BillDate = TestBillDate; 
            sut.Address = TestAddress;
            //Assert
            Assert.IsNotNull(sut);
            Assert.AreEqual(TestCustomerName, sut.CustomerName);
            Assert.AreEqual(TestPhoneNumber, sut.PhoneNumber);
            Assert.AreEqual(TestBillDate, sut.BillDate);
            Assert.AreEqual(TestBillAmount, sut.BillAmount);
            Assert.AreEqual(TestAddress, sut.Address);
        }

        [TestMethod]
        public void CreatesClassStructureForCustomerModel()
        {
            //Arrange
            CustomerBase sut = new Customer(null);
            //Act
            sut.CustomerName = TestCustomerName;
            sut.PhoneNumber = TestPhoneNumber;
            sut.BillAmount = TestBillAmount;
            sut.BillDate = TestBillDate;
            sut.Address = TestAddress;
            //Assert
            Assert.IsNotNull(sut);
            Assert.AreEqual(TestCustomerName, sut.CustomerName);
            Assert.AreEqual(TestPhoneNumber, sut.PhoneNumber);
            Assert.AreEqual(TestBillDate, sut.BillDate);
            Assert.AreEqual(TestBillAmount, sut.BillAmount);
            Assert.AreEqual(TestAddress, sut.Address);
        }
    }
}
