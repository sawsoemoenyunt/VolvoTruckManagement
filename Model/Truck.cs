namespace VolvoTruckManagement.Model
{
    /// <summary>
    /// Represents a truck entity with identification and specification details.
    /// </summary>
    public class Truck
    {
        /// <summary>
        /// Unique truck number (auto-generated between 1 and 99).
        /// </summary>
        public int TruckNumber { get; set; }

        /// <summary>
        /// Brand of the truck (e.g., Volvo, Mack, or MD).
        /// </summary>
        public string Brand { get; set; } = string.Empty;

        /// <summary>
        /// Vehicle Identification Number (VIN), must be 17 characters, alphanumeric, and unique.
        /// </summary>
        public string VIN { get; set; } = string.Empty;

        /// <summary>
        /// Manufacturing year of the truck (not older than 20 years, not in the future).
        /// </summary>
        public int BuildDate { get; set; } = 0;

        /// <summary>
        /// Optional remarks or description about the truck (up to 1000 characters).
        /// </summary>
        public string Comment { get; set; } = string.Empty;
    }
}
