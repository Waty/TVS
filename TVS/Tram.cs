namespace TVS
{
    /// <summary>
    ///     Class to create or keep track of a Tram
    /// </summary>
    public class Tram
    {
        /// <summary>
        /// Tram ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Tram number
        /// </summary>
        public int Nummer { get; set; }

        /// <summary>
        /// Tram lenght
        /// </summary>
        public int Lengte { get; set; }

        /// <summary>
        /// Shows whether the Tram needs to be cleaned.
        /// </summary>
        public bool Vervuild { get; set; }

        /// <summary>
        /// Shows whether the Tram needs to be repaired.
        /// </summary>
        public bool Defect { get; set; }

        /// <summary>
        /// Shows whether the Tram is suited fo have a "Conducteur"
        /// </summary>
        public bool ConductGeschikt { get; set; }

        /// <summary>
        /// Shows whether the Tram is available
        /// </summary>
        public bool Beschikbaar { get; set; }

        /// <summary>
        /// Shows the ID of the Tram type
        /// </summary>
        public int TramTypeID { get; set; }

        /// <summary>
        /// Shows the ID of the "Remise" it belongs to.
        /// </summary>
        public int RemiseId { get; set; }

        /// <summary>
        /// Geeft de status van de Tram aan
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// ToString function of the class.
        /// </summary>
        /// <returns>Returns the data in a string</returns>
        public override string ToString()
        {
            return "ID: " + Id + ", Nummer: " + Nummer + "";
        }
    }
}