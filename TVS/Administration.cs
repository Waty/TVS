using System.Collections.Generic;

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
    }
}