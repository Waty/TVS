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
        /// <summary>
        /// 
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Nummer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Lengte { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool Vervuild { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool Defect { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool ConductGeschikt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool Beschikbaar { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int TramTypeID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int RemiseId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// Lege constructor
        /// </summary>
        public Tram()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "ID: " + ID + ", Nummer: " + Nummer + "";
        }
    }
}
