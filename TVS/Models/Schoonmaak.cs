using System;

namespace TVS.Models
{
    /// <summary>
    ///     Contains all the information about a cleanup
    /// </summary>
    public class Schoonmaak
    {
        /// <summary>
        ///     Types of cleaning availlable
        /// </summary>
        public enum SchoonmaakType
        {
            /// <summary>
            ///     Should be done once 3 months (includes a <see cref="KleineBeurt" />)
            /// </summary>
            GroteBeurt,

            /// <summary>
            ///     Should be done every month
            /// </summary>
            KleineBeurt
        }

        /// <summary>
        ///     Constructs the class with the given parameters
        /// </summary>
        public Schoonmaak(Medewerker medewerker, DateTime date, Tram tram, SchoonmaakType type)
        {
            Medewerker = medewerker;
            Date = date;
            Tram = tram;
            Type = type;
        }

        /// <summary>
        ///     The type of cleanup
        /// </summary>
        public SchoonmaakType Type { get; }

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