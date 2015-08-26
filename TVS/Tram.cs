namespace TVS
{
    /// <summary>
    ///     Klasse om een Tram aan te maken.
    /// </summary>
    public class Tram
    {
        /// <summary>
        /// ID van de Tram
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Nummer van de Tram
        /// </summary>
        public int Nummer { get; set; }

        /// <summary>
        /// Lengte van de Tram
        /// </summary>
        public int Lengte { get; set; }

        /// <summary>
        /// Geeft aan of the Tram moet worden schoongemaakt.
        /// </summary>
        public bool Vervuild { get; set; }

        /// <summary>
        /// Geeft aan of de trein moet worden gerepareerd.
        /// </summary>
        public bool Defect { get; set; }

        /// <summary>
        /// Geeft aan of de Tram geschikt is om een conducteur bij te hebben.
        /// </summary>
        public bool ConductGeschikt { get; set; }

        /// <summary>
        /// Geeft aan of dat de Tram beschikbaar is
        /// </summary>
        public bool Beschikbaar { get; set; }

        /// <summary>
        /// </summary>
        public int TramTypeID { get; set; }

        /// <summary>
        /// Geeft het TypeID van de Tram aan.
        /// </summary>
        public int RemiseId { get; set; }

        /// <summary>
        /// Geeft de status van de Tram aan
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// De ToString van de Tram
        /// </summary>
        /// <returns>Geeft een string met de data van de Tram</returns>
        public override string ToString()
        {
            return "ID: " + ID + ", Nummer: " + Nummer + "";
        }
    }
}