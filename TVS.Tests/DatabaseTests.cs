using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TVS.Tests
{
    /// <summary>
    ///     Test for the <see cref="Database" /> class, should only be used with the default test data from the
    ///     createscript.sql
    /// </summary>
    [TestClass]
    public class DatabaseTests
    {
        [TestMethod]
        public void DataLoginTest()
        {
            Assert.AreEqual("Schoonmaker", Database.Login("Sjaak_Schoonmaker", "TestTest1"));

            Assert.AreEqual(null, Database.Login("Invalid", "Login"));
        }
    }
}