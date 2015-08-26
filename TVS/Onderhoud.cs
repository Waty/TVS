using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVS
{
    /// <summary>
    ///     Maintenance and/or repairs
    /// </summary>
    class Onderhoud
    {
        /// <summary>
        ///     Enum for the type of maintenance
        /// </summary>
        public enum TypeOnderhoud
        {
            GroteServicebeurt,
            KleineServicebeurt,
            Reparatie
        }
       /// <summary>
       ///     Timeindication of repairs
       /// </summary>
        public DateTime Tijd { get; set; }
       /// <summary>
       ///      ID of the Tram being repaired
       /// </summary>
        public int TramId { get; set; }
        /// <summary>
        ///     The technician 
        /// </summary>
        public Medewerker Medewerker { get; set; }
        /// <summary>
        ///     Type of Maintenance
        /// </summary>
        public TypeOnderhoud Type { get; set; }

        /// <summary>
        ///     constructor
        /// </summary>
        /// <param name="medewerker"> The technician</param>
        /// <param name="date"> the indicated time when this is finished</param>
        /// <param name="tramid">ID of the Tram</param>
        /// <param name="type">Type of maintenance</param>
        public Onderhoud(Medewerker medewerker, DateTime date, int tramid, TypeOnderhoud type )
        {
            Medewerker = medewerker;
            Tijd = date;
            TramId = tramid;
            Type = type;
        }
    }
    
}
