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
        /// <summary>
        ///     List for the remises
        /// </summary>
        public List<Remise> Remises;

        /// <summary>
        ///     List for the Tracks
        /// </summary>
        public List<Spoor> Sporen;

        /// <summary>
        ///     List for the Trams
        /// </summary>
        public List<Tram> Trams;

        /// <summary>
        ///     Sends the SetBroken to the database
        /// </summary>
        public void SetBroken(int nummer)
        {
            Database.SetBroken(nummer);
        }

        /// <summary>
        ///     Sends the SetVervuild to the database
        /// </summary>
        public void SetVervuild(int nummer)
        {
            Database.SetVervuild(nummer);
        }

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
        public void AssignSector(int nummer)
        {
            Tram tram = Database.GetAllTrams().First(t => t.Nummer == Convert.ToInt32(nummer));

            if (tram.Vervuild)
            {
                for (var i = 21; i <= 24; i++)
                {
                    if (Database.IsRailAvailable(i))
                    {
                        Database.CreateSector(i, tram.Id);
                    }
                }
            }
            else if (tram.Defect)
            {
                for (var i = 38; i <= 41; i++)
                {
                    if (Database.IsRailAvailable(i))
                    {
                        Database.CreateSector(i, tram.Id);
                        break;
                    }
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
                List<Spoor> sporen = Database.GetSelectedTracks(i).ToList();
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
            Sector s = Database.GetSector(tramId);
            return s;
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
