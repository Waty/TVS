namespace TVS.Models
{
    /// <summary>
    ///     Class to control a sector
    /// </summary>
    public class Sector
    {
        /// <summary>
        ///     Constructor
        /// </summary>
        public Sector(int spoorid, int tramid, int nummer, bool beschikbaar, bool blokkade)
        {
            SpoorId = spoorid;
            TramId = tramid;
            Nummer = nummer;
            Beschikbaar = beschikbaar;
            Blokkade = blokkade;
        }

        /// <summary>
        ///     Empty constructor
        /// </summary>
        public Sector() {}

        /// <summary>
        ///     ID of the track
        /// </summary>
        public int SpoorId { get; set; }

        /// <summary>
        ///     Id of the Tram
        /// </summary>
        public int TramId { get; set; }

        /// <summary>
        ///     Number of the sector
        /// </summary>
        public int Nummer { get; set; }

        /// <summary>
        ///     Checks of the sector is available
        /// </summary>
        public bool Beschikbaar { get; set; }

        /// <summary>
        ///     Checks of the sector is blocked
        /// </summary>
        public bool Blokkade { get; set; }
    }
}