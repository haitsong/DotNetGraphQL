using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Addresses for people and organizations.
    ///</summary>
    public class Address
    {
        /// street address
        public String StreetAddress { get; set; } = string.Empty;
        /// city
        public String City { get; set; } = string.Empty;
        /// country
        public String Country { get; set; } = string.Empty;
        /// state
        public String State { get; set; } = string.Empty;
        /// zip code
        public String ZipOrPostalCode { get; set; } = string.Empty;
    }
}


