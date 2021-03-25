using DotNetGraphQL.Common.Enums;
using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Contact information for party.
    ///</summary>
    public class ContactInfo
    {
        ///Identity of contact must be unique inside party.
        public Guid Id { get; } = Guid.NewGuid();
        ///$Management information for action Refer to: Structure: Element/v1
        public Element Header { get; } = new Element();
        ///$Type of contact for party. Refer to: Enum: ContactType/v1
        public ContactType Type { get; } = ContactType.ATTORNEY;
        ///Contact name
        public String Name { get; } = string.Empty;
        ///Phone number for contact.
        public String Phone { get; } = string.Empty;
    }
}


