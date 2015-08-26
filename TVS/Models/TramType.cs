namespace TVS.Models
{
    /// <summary>
    /// </summary>
    public class TramType
    {
        /// <summary>
        ///     Constructor
        /// </summary>
        /// <param name="id">   ID of the tramtype</param>
        /// <param name="omschrijving"> Description of the tramtype</param>
        public TramType(int id, string omschrijving)
        {
            Id = id;
            Omschrijving = omschrijving;
        }

        /// <summary>
        ///     Empty constructor
        /// </summary>
        public TramType() {}

        /// <summary>
        ///     ID of the tramtype
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///     Description
        /// </summary>
        public string Omschrijving { get; set; }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A string that represents the current object.
        /// </returns>
        public override string ToString()
        {
            return Omschrijving;
        }
    }
}