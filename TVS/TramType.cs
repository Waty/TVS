using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVS
{
    /// <summary>
    ///     
    /// </summary>
    public class TramType
    {
        /// <summary>
        /// ID of the tramtype
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        ///     Description
        /// </summary>
        public string Omschrijving { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">   ID of the tramtype</param>
        /// <param name="omschrijving"> Description of the tramtype</param>
        public TramType(int id , string omschrijving)
        {
            Id = id;
            Omschrijving = omschrijving;
        }
        /// <summary>
        ///     Empty constructor
        /// </summary>
        public TramType()
        {

        }
    }
}
