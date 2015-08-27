namespace TVS.Models
{
    /// <summary>
    ///     Class for the tracks
    /// </summary>
    public class Spoor
    {
        /// <summary>
        ///     Constructor
        /// </summary>
        public Spoor(int id, int remise, int nummer, int lengte, bool beschikbaar, bool inuitrijspoor)
        {
            Id = id;
            Remise_Id = remise;
            Nummer = nummer;
            Lengte = lengte;
            Beschikbaar = beschikbaar;
            InUitRijspoor = inuitrijspoor;
        }

        /// <summary>
        ///     Empty constructor
        /// </summary>
        public Spoor() {}

        /// <summary>
        ///     ID of the track
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///     Id of the remise
        /// </summary>
        public int Remise_Id { get; set; }

        /// <summary>
        ///     Number of the track
        /// </summary>
        public int Nummer { get; set; }

        /// <summary>
        ///     Length of the track
        /// </summary>
        public int Lengte { get; set; }

        /// <summary>
        ///     Availability of the track
        /// </summary>
        public bool Beschikbaar { get; set; }

        /// <summary>
        ///     Is the track meant for driving in and out or not.
        /// </summary>
        public bool InUitRijspoor { get; set; }

        /// <summary>
        ///     Is the track blocked or not.
        /// </summary>
        public bool Geblokkeerd { get; set; }
    }
}