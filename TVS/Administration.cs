using System;
using System.Collections.Generic;
using System.Linq;
using TVS.Models;

namespace TVS
{
    /// <summary>
    ///     Class that sends through all information and methods.
    /// </summary>
    public class Administration
    {
        private readonly int[] _cleaningTracks = Enumerable.Range(21, 4).ToArray();
        private readonly int[] _maintenanceTracks = Enumerable.Range(38, 4).ToArray();

        /// <summary>
        ///     Gets all the tramtypes
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TramType> GeTramTypes()
        {
            return Database.GetTramtypes();
        }

        /// <summary>
        ///     Sends the new tram order to the database
        /// </summary>
        public void NewTram(int remiseid, int typeid, int nummer, int lengte, int geschikt, int beschikbaar)
        {
            Database.NewTram(remiseid, typeid, nummer, lengte, geschikt, beschikbaar);
        }

        /// <summary>
        ///     Assigns the sector to the right track
        /// </summary>
        public void AssignSector(Tram tram)
        {
            if (tram.Vervuild)
            {
                foreach (int track in _cleaningTracks.Where(Database.IsRailAvailable))
                {
                    Database.CreateSector(track, tram.Id);
                    return;
                }
            }
            else if (tram.Defect)
            {
                foreach (int track in _maintenanceTracks.Where(Database.IsRailAvailable))
                {
                    Database.CreateSector(track, tram.Id);
                    return;
                }
            }
            // Combino heeft een speciaal spoor nodig.
            else if (tram.TramTypeId == 1)
            {
                if (Database.IsRailAvailable(33))
                {
                    Database.CreateSector(33, tram.Id);
                    return;
                }
            }


            for (var i = 0; i < 1337; i++)
            {
                List<Spoor> sporen = Database.GetSelectedTracks(i)
                    .Where(s => !_maintenanceTracks.Contains(s.Id))
                    .Where(s => !_cleaningTracks.Contains(s.Id))
                    .ToList();

                if (sporen.Count != 0)
                {
                    Spoor spoor = sporen.First();
                    Database.CreateSector(spoor.Id, tram.Id);
                    break;
                }
            }
        }

        /// <summary>
        ///     retrieve Sector from Database
        /// </summary>
        /// <param name="tramId"></param>
        public Sector GetSector(int tramId)
        {
            return Database.GetSector(tramId);
        }

        /// <summary>
        ///     Gets wanted Track according to ID
        /// </summary>
        /// <param name="spoorId"></param>
        /// <returns></returns>
        public int GetTracks(int spoorId)
        {
            return Database.GetAllTracks().Single(spoor => spoor.Id == spoorId).Nummer;
        }
    }
}