using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  
    ///</summary>
    public class Person
    {
        /// person id 
        public String Id { get; } = string.Empty;
        /// last time
        public String LastName { get; } = string.Empty;
        /// first time
        public String FirstName { get; } = string.Empty;
        /// email address
        public String Email { get; } = string.Empty;
        /// department
        public String Department { get; } = string.Empty;
        /// phone number
        public String Phone { get; } = string.Empty;
        ///The organization employing the individual (optional)
        public String OrganizationId { get; } = string.Empty;
        /// address of the person, refer to: Address
        public Address[] Addresses { get; } = new Address[0];
    }
}


