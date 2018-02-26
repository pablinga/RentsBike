using RentBike.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestRentBikes
{


    /// <summary>
    ///This is a test class for RentControllerTest and is intended
    ///to contain all RentControllerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RentControllerTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }


        /// <summary>
        ///A test for TypeRent Constructor
        ///</summary>
        [TestMethod()]
        public void TypeRentConstructorTest()
        {
            TimeEnum time = TimeEnum.Hour;
            TypeRent typeRent = new TypeRent(time);
            Assert.IsNotNull(typeRent);
        }

        /// <summary>
        ///A test for Rent Constructor
        ///</summary>
        [TestMethod()]
        public void RentConstructorTest()
        {
            TypeRent typeRent = new TypeRent(TimeEnum.Day); 
            double amountTime = 2; 
            Rent rent = new Rent(typeRent, amountTime);
            Assert.IsNotNull(rent);
        }

        /// <summary>
        ///A test for TotalPrice by Hour
        ///</summary>
        [TestMethod()]
        public void TotalPriceByHourTest()
        {
            int dni = 23456765;
            string name = "Juan Lopez";
            Client client = new Client(dni, name);

            TypeRent hour = new TypeRent(TimeEnum.Hour);
            Rent rentHour = new Rent(hour, 4);
            client.rents.Add(rentHour);

            double expected = 20;
            double actual;
            actual = client.TotalPrice();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for TotalPrice by Day
        ///</summary>
        [TestMethod()]
        public void TotalPriceByDayTest()
        {
            int dni = 23456765;
            string name = "Juan Lopez";
            Client client = new Client(dni, name);

            TypeRent day = new TypeRent(TimeEnum.Day);
            Rent rentDay = new Rent(day, 4);
            client.rents.Add(rentDay);

            double expected = 80;
            double actual;
            actual = client.TotalPrice();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for TotalPrice by Week
        ///</summary>
        [TestMethod()]
        public void TotalPriceByWeekTest()
        {
            int dni = 23456765;
            string name = "Juan Lopez";
            Client client = new Client(dni, name);

            TypeRent week = new TypeRent(TimeEnum.Week);
            Rent rentWeek = new Rent(week, 4);
            client.rents.Add(rentWeek);

            double expected = 240;
            double actual;
            actual = client.TotalPrice();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for TotalPrice with Discount
        ///</summary>
        [TestMethod()]
        public void TotalPriceWithDiscountTest()
        {
            int dni = 23456765;
            string name = "Juan Lopez"; 
            Client client = new Client(dni, name);

            TypeRent hour = new TypeRent(TimeEnum.Hour);
            Rent rentHour = new Rent(hour, 3);
            client.rents.Add(rentHour);

            TypeRent day = new TypeRent(TimeEnum.Day);
            Rent rentDay = new Rent(day, 2);
            client.rents.Add(rentDay);

            TypeRent week = new TypeRent(TimeEnum.Week);
            Rent rentWeek = new Rent(week, 1);
            client.rents.Add(rentWeek);

            double expected = 80.5; 
            double actual;
            actual = client.TotalPrice();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ReturnsBike
        ///</summary>
        [TestMethod()]
        public void ReturnBikeTest()
        {
            int dni = 23456765;
            string name = "Juan Lopez";
            Client client = new Client(dni, name);
            client.ReturnsBike();
            int expectedCount = 0;
            int actualCount = client.rents.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        /// <summary>
        ///A test for Client Constructor
        ///</summary>
        [TestMethod()]
        public void ClientConstructorTest()
        {
            int dni = 23456765;
            string name = "Juan Lopez";
            Client client = new Client(dni, name);
            Assert.IsNotNull(client);
        }
    }
}
