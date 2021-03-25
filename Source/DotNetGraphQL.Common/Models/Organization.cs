using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  
    ///</summary>
    public class Organization
    {
        /// orgnization id
        public String OrganizationId { get; } = string.Empty;
        /// name
        public String Name { get; } = string.Empty;
        /// description
        public String Description { get; } = string.Empty;
        ///$Valid addresses used by the organization Refer to: Structure[]: Address/v1
        public Address[] Addresses { get; } = new Address[0];
    }
}


