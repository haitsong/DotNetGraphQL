using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Contact information for object support.
    ///</summary>
    public class Contact
    {
        ///$Identity of organization or person. Refer to: Structure: /Identity
        public Identity Identity { get; } = new Identity();
        ///The URL pointing to the contact information.
        public String URL { get; } = string.Empty;
        ///The email address of the contact person/organization.
        public String EMail { get; } = string.Empty;
    }
}


