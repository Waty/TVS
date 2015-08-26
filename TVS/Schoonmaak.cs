using System;

namespace TVS
{
    /// <summary>
    ///     Contains all the information about a cleanup
    /// </summary>
    public class Schoonmaak
    {
        /// <summary>
        ///     Constructs the class with the given parameters
        /// </summary>
        public Schoonmaak(Medewerker medewerker, DateTime date, Tram tram)
        {
            Medewerker = medewerker;
            Date = date;
            Tram = tram;
        }

        /// <summary>
        ///     the employee that performed the cleanup
        /// </summary>
        public Medewerker Medewerker { get; }

        /// <summary>
        ///     The <see cref="DateTime" /> of the cleanup
        /// </summary>
        public DateTime Date { get; }

        /// <summary>
        ///     The <see cref="Tram" /> that got cleaned
        /// </summary>
        public Tram Tram { get; }
    }
}