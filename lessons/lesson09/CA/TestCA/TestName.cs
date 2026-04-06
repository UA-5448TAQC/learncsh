using CA;

namespace TestCA
{
    [TestClass]
    public sealed class TestName
    {
        [TestMethod]
        public void TestMethodCreateName()
        {
            string firstName = "John";
            string lastName = "Doe";
            string middleName = "Smith";
            Name name1 = new Name(firstName, lastName, middleName);

            Assert.AreEqual(firstName, name1.FirstName);
            Assert.AreEqual(lastName, name1.LastName);
            Assert.AreEqual(middleName, name1.MiddleName);

        }

        [TestMethod]
        public void TestMethodCreateNameEmptylastName()
        {
            string firstName = "John";
            string lastName = "Doe";
            Name name1 = new Name(firstName, lastName);

            Assert.AreEqual(firstName, name1.FirstName);
            Assert.AreEqual(lastName, name1.LastName);
            Assert.AreEqual(string.Empty, name1.MiddleName);

        }
    }
}
