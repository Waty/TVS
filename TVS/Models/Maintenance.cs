using System;

namespace TVS.Models
{
    /// <summary>
    ///     Contains information about the executed maintenance
    /// </summary>
    public class Maintenance
    {
        /// <summary>
        ///     The result of the maintenance
        /// </summary>
        public enum MaintenanceType
        {
            /// <summary>
            ///     The tram was maintained
            /// </summary>
            Onderhouden,

            /// <summary>
            ///     The tram was maintained but needs cleaning
            /// </summary>
            Vervuild
        }

        /// <summary>
        ///     Contructs the maintenance with the given values
        /// </summary>
        public Maintenance(Medewerker medewerker, DateTime date, Tram tram, MaintenanceType type)
        {
            Medewerker = medewerker;
            Date = date;
            Tram = tram;
            Type = type;
        }

        /// <summary>
        ///     The <see cref="Medewerker" /> that executed the mainenance
        /// </summary>
        public Medewerker Medewerker { get; }

        /// <summary>
        ///     The date of execution
        /// </summary>
        public DateTime Date { get; }

        /// <summary>
        ///     The tram that was maintained
        /// </summary>
        public Tram Tram { get; }

        /// <summary>
        ///     The resulting type of the maintenance
        /// </summary>
        public MaintenanceType Type { get; }
    }
}