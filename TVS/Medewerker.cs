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
            //TODO: add proper comments
            /// <summary>
            /// </summary>
            Beheerder = 1,

            /// <summary>
            /// </summary>
            Wagenparkbeheerder = 2,

            /// <summary>
            /// </summary>
            Bestuurder = 3,

            /// <summary>
            /// </summary>
            Technicus = 4,

            /// <summary>
            /// </summary>
            Schoonmaker = 5
        }

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
    }
}