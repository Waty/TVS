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
                if (Database.IsRailAvailable(41))
                {
                    Database.CreateSector(41, tram.Id);
                }

                else if (Database.IsRailAvailable(42))
                {
                    Database.CreateSector(42, tram.Id);
                }
                else if (Database.IsRailAvailable(43))
                {
                    Database.CreateSector(43, tram.Id);
                }
                else if (Database.IsRailAvailable(44))
                {
                    Database.CreateSector(44, tram.Id);
                }
            }
            if (tram.Defect)
            {
                if (Database.IsRailAvailable(74))
                {
                    Database.CreateSector(74, tram.Id);
                }
                else if (Database.IsRailAvailable(75))
                {
                    Database.CreateSector(75, tram.Id);
                }
                else if (Database.IsRailAvailable(76))
                {
                    Database.CreateSector(76, tram.Id);
                }
                else if (Database.IsRailAvailable(77))
                {
                    Database.CreateSector(77, tram.Id);
                }
            }
            if (tram.TramTypeId == 1)
            {
                if (Database.IsRailAvailable(58))
                {
                    Database.CreateSector(58, tram.Id);
                }
            }
            else
            {
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
        }
    }
    }
