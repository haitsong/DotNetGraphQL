using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  
    ///</summary>
    public class Organization
    {
        /// orgnization id
        public String OrganizationId { get; set; } = string.Empty;
        /// name
        public String Name { get; set; } = string.Empty;
        /// description
        public String Description { get; set; } = string.Empty;
        ///$Valid addresses used by the organization Refer to: Structure[]: Address/v1
        public Address[] Addresses { get; set; } = new Address[0];
    }
}


