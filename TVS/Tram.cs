using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVS
{
    /// <summary>
    /// Klasse om een Tram aan te maken.
    /// </summary>
    public class Tram
    {
        public int ID { get; set; }

        public int Nummer { get; set; }

        public int Lengte { get; set; }

        public bool Vervuild { get; set; }

        public bool Defect { get; set; }

        public bool ConductGeschikt { get; set; }

        public bool Beschikbaar { get; set; }

        public int TramTypeID { get; set; }

        public int RemiseId { get; set; }

        public Status Status { get; set; }

        /// <summary>
        /// Lege constructor
        /// </summary>
        public Tram()
        {

        }

    }
}
