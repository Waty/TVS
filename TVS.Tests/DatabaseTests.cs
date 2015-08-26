using Microsoft.VisualStudio.TestTools.UnitTesting;
using TVS.Models;

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
        public void SjaakLoginTest()
        {
            Assert.AreEqual(Medewerker.FunctieType.Schoonmaker, Database.Login("Sjaak_Schoonmaker", "TestTest1").Functie);
        }

        [TestMethod]
        public void InvalidLoginTest()
        {
            Assert.IsNull(Database.Login("Invalid", "password"));
        }
    }
}