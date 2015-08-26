namespace TVS
{
    /// <summary>
    ///     Contains all the info about the medewerker
    /// </summary>
    public class Medewerker
    {
        /// <summary>
        ///     Describes the type of work the <see cref="Medewerker" /> is hired to do
        /// </summary>
        public enum FunctieType
        {
            /// <summary>
            ///     Main controller
            /// </summary>
            Beheerder = 1,

            /// <summary>
            ///     Tram controller
            /// </summary>
            Wagenparkbeheerder = 2,

            /// <summary>
            ///     Driver
            /// </summary>
            Bestuurder = 3,

            /// <summary>
            ///     Technician
            /// </summary>
            Technicus = 4,

            /// <summary>
            ///     Cleaner
            /// </summary>
            Schoonmaker = 5
        }

        /// <summary>
        ///     Constructor
        /// </summary>
        public Medewerker(int id, string naam, FunctieType functie)
        {
            Id = id;
            Naam = naam;
            Functie = functie;
        }

        /// <summary>
        ///     Empty constructor
        /// </summary>
        public Medewerker() {}

        /// <summary>
        ///     The unique identification number for <see cref="Medewerker" />s
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///     The name of the <see cref="Medewerker" />
        /// </summary>
        public string Naam { get; set; }

        /// <summary>
        ///     The Functie of the <see cref="Medewerker" />
        /// </summary>
        public FunctieType Functie { get; set; }

        /// <summary>
        ///     Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        ///     A string that represents the current object.
        /// </returns>
        public override string ToString()
        {
            return Naam;
        }
    }
}