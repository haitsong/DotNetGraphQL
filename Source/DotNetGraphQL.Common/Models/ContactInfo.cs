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
        public Guid Id { get; set; } = Guid.NewGuid();
        ///$Management information for action Refer to: Structure: Element/v1
        public Element Header { get; set; } = new Element();
        ///$Type of contact for party. Refer to: Enum: ContactType/v1
        public ContactType Type { get; set; } = ContactType.ATTORNEY;
        ///Contact name
        public String Name { get; set; } = string.Empty;
        ///Phone number for contact.
        public String Phone { get; set; } = string.Empty;
    }
}


