using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CA;

namespace TestCA
{
    [TestClass]
    public sealed class TestPerson
    {
        Adress adress;
        int birthday = 1990;

        [TestInitialize]
        public void TestInitialize()
        {
            // Code to set up test environment, if needed
            adress = new CA.Adress("New York", "5th Avenue", "123", 10001);

        }
        [TestCleanup]
        public void TestCleanup()
        {
            // Code to clean up test environment, if needed
        }

        public TestPerson()
        {
            // Code to set up test environment, if needed
        }

        [TestMethod]
        public void TestMethodCreatePerson()
        {
            string firstName = "John";
            string lastName = "Doe";
            string middleName = "Smith";
            int birthday = 1990;
            CA.Person person1 = new CA.Person(firstName, lastName, middleName, adress, birthday);
            Assert.AreEqual(firstName, person1.ToString().Split(',')[0].Split(' ')[0]);
            Assert.AreEqual(lastName, person1.ToString().Split(',')[0].Split(' ')[2]);
            Assert.AreEqual(middleName, person1.ToString().Split(',')[0].Split(' ')[1]);
            Assert.AreEqual(adress.ToString(), person1.ToString().Split(',')[1].Trim() + ", " + person1.ToString().Split(',')[2].Trim());
            Assert.AreEqual(DateTime.Now.Year - birthday, person1.GetAge());
        }

    }
}
