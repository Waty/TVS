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

        [TestMethod]
        public void DefectTest()
        {
            Assert.AreEqual(1, Database.SetBroken(2001));

            Tram tram = Database.GetAllTrams().First(t => t.Nummer == 2001);
            Assert.AreEqual(true, tram.Defect);
        }

        [TestMethod]
        public void GetAllMedewerkersTest()
        {
            List<Medewerker> allMedewerkers = Database.GetAllMedewerkers().ToList();

            Assert.AreEqual(5, allMedewerkers.Count);

            Medewerker medewerker = allMedewerkers[0];
            Assert.AreEqual(1, medewerker.Id);
            Assert.AreEqual("Jan_Beheerder", medewerker.Naam);
        }

        [TestMethod]
        public void ToggleRailBlockTest()
        {
            Assert.AreEqual(1, Database.ToggleRailBlock(12, true));

            Spoor spoor = Database.GetAllTracks().First(s => s.Geblokkeerd);
            Assert.AreEqual(true, spoor.Geblokkeerd);
        }

        [TestMethod]
        public void IsRailBlockedTest()
        {
            Assert.AreEqual(1, Database.ToggleRailBlock(13, true));

            Assert.AreEqual(true, Database.IsRailBlocked(13));
        }

        [TestMethod]
        public void GetTramTypesTest()
        {
            List<TramType> allTramTypes = Database.GetTramtypes().ToList();

            Assert.AreEqual(7, allTramTypes.Count);

            TramType tramtype = allTramTypes[0];
            Assert.AreEqual(1, tramtype.Id);
            Assert.AreEqual("Combino", tramtype.Omschrijving);
        }

        [TestMethod]
        public void GetMaintenaceHistoryTest()
        {
            List<Maintenance> allMaintenances = Database.GetMaintenanceHistory().ToList();

            Maintenance main = allMaintenances[0];
            Assert.AreEqual("Klaas_Technicus", main.Medewerker.ToString());
        }
    }
}