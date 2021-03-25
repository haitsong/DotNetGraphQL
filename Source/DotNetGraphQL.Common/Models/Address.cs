using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Addresses for people and organizations.
    ///</summary>
    public class Address
    {
        /// street address
        public String StreetAddress { get; } = string.Empty;
        /// city
        public String City { get; } = string.Empty;
        /// country
        public String Country { get; } = string.Empty;
        /// zip code
        public String ZipOrPostalCode { get; } = string.Empty;
    }
}


