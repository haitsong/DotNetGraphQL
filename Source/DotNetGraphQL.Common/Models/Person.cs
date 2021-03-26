using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  
    ///</summary>
    public class Person
    {
        /// person id 
        public String Id { get; set;  } = string.Empty;
        /// last time
        public String LastName { get; set; } = string.Empty;
        /// first time
        public String FirstName { get; set;  } = string.Empty;
        /// email address
        public String Email { get; set; } = string.Empty;
        /// department
        public String Department { get; set; } = string.Empty;
        /// phone number
        public String Phone { get; set; } = string.Empty;
        ///The organization employing the individual (optional)
        public String OrganizationId { get; set; } = string.Empty;
        /// address of the person, refer to: Address
        public Address[] Addresses { get; set; } = new Address[0];
    }
}


