namespace TVS.Models
{
    /// <summary>
    ///     Class for a Remise
    /// </summary>
    public class Remise
    {
        /// <summary>
        ///     Constructor
        /// </summary>
        public Remise(int id, string naam, int groteSc, int kleineSc, int groteSe, int kleineSe)
        {
            Id = id;
            Naam = naam;
            GroteSchoonmaakbeurt = groteSc;
            KleineSchoonmaakbeurt = kleineSc;
            GroteServicebeurt = groteSe;
            KleineServicebeurt = kleineSe;
        }

        /// <summary>
        ///     Empty Constructor
        /// </summary>
        public Remise() {}

        /// <summary>
        ///     ID of the remise
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///     Name of the remise
        /// </summary>
        public string Naam { get; set; }

        /// <summary>
        ///     Large cleaning
        /// </summary>
        public int GroteSchoonmaakbeurt { get; set; }

        /// <summary>
        ///     Small cleaning
        /// </summary>
        public int KleineSchoonmaakbeurt { get; set; }

        /// <summary>
        ///     Large service
        /// </summary>
        public int GroteServicebeurt { get; set; }

        /// <summary>
        ///     Small sevice
        /// </summary>
        public int KleineServicebeurt { get; set; }
    }
}