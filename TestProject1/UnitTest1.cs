using Lab1;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Constructor_SetsPropertiesCorrectly()
        {
            string name = "TestCompany";
            int price = 150;
            float avgTime = 2.5f;
            int year = 1998;
            float mass = 1000f;
            float rating = 4.5f;
            string phone = "89101234567";

            var company = new TransportCompany(name, price, avgTime, year, mass, rating, phone);

            Assert.Equal(name, company.name);
            Assert.Equal(price, company.pricePerKilometer);
            Assert.Equal(avgTime, company.averageDeliveryTime);
            Assert.Equal(year, company.yearFounded);
            Assert.Equal(mass, company.transportedMass);
            Assert.Equal(rating, company.rating);
            Assert.Equal(phone, company.phoneNumber);
        }

        [Fact]
        public void PrintName_ReturnsCorrectName()
        {
            var company = new TransportCompany("TestCompany");

            var result = company.PrintName();

            Assert.Equal("Название фирмы: TestCompany", result);
        }

        [Fact]
        public void PrintName_ReturnsMessage_WhenNameIsEmpty()
        {
            var company = new TransportCompany("");

            var result = company.PrintName();

            Assert.Equal("У фирмы нет названия", result);
        }

        [Fact]
        public void PriceToHex_ReturnsCorrectHex()
        {
            var company = new TransportCompany("TestCompany", 255);

            var result = company.PriceToHex();

            Assert.Equal("ff", result);  // 255 в hex — ff
        }

        [Fact]
        public void CountObj_IncrementsCorrectly()
        {
            int initialCount = TransportCompany.countObj;

            var company1 = new TransportCompany();
            var company2 = new TransportCompany();

            Assert.Equal(initialCount + 2, TransportCompany.countObj);
        }
    }
}
