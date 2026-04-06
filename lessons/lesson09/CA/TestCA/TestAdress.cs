using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CA;

namespace TestCA
{
    [TestClass]
    public sealed class TestAdress
    {
        string city = "New York";
        string street = "5th Avenue";
        string houseNumber = "123";
        int postalCode = 10001;
        Adress adress;

        [TestInitialize]
        public void TestInitialize()
        {
            adress = new Adress(city, street, houseNumber, postalCode);

        }

        [TestMethod]
        public void TestMethodAdressCheck()
        {
            Assert.AreEqual(city, adress.City);
            Assert.AreEqual(street, adress.Street);
            Assert.AreEqual(houseNumber, adress.HouseNumber);
            Assert.AreEqual(postalCode, adress.PostalCode);
        }

        [TestMethod]
        public void TestMethodToString()
        {
            string expectedString = $"{street} {houseNumber}, {postalCode} {city}"; ;

            Assert.AreEqual(expectedString, adress.ToString());
        }

        [TestMethod]
        public void TestMethodAdressChengeCity()
        {
            string newCity = "Los Angeles";
            adress.City = newCity;
            Assert.AreEqual(newCity, adress.City);
            Assert.AreEqual(street, adress.Street);
            Assert.AreEqual(houseNumber, adress.HouseNumber);
            Assert.AreEqual(postalCode, adress.PostalCode);
        }
        [TestMethod]
        public void TestMethodAdressChengeStreet()
        {
            string newStreet = "12th Avenue";
            adress.Street = newStreet;
            Assert.AreEqual(city, adress.City);
            Assert.AreEqual(newStreet, adress.Street);
            Assert.AreEqual(houseNumber, adress.HouseNumber);
            Assert.AreEqual(postalCode, adress.PostalCode);
        }

    }
}
