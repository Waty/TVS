using System.Collections.Generic;
using System.Linq;
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

        [TestMethod]
        public void GetAllTramsTest()
        {
            List<Tram> allTrams = Database.GetAllTrams().ToList();

            Assert.AreEqual(214, allTrams.Count);

            Tram tram = allTrams[0];
            Assert.AreEqual(1, tram.Id);
            Assert.AreEqual(2001, tram.Nummer);
        }

        [TestMethod]
        public void VervuildTest()
        {
            Assert.AreEqual(1, Database.SetVervuild(2001));

            Tram tram = Database.GetAllTrams().First(t => t.Nummer == 2001);
            Assert.AreEqual(true, tram.Vervuild);
        }
    }
}