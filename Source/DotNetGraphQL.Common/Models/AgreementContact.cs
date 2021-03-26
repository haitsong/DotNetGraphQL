using DotNetGraphQL.Common.Enums;
using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Contact of agreement Party. Contact reference to party contact by type or id.
    ///</summary>
    public class AgreementContact
    {
        ///Identity of agreement party contact must be unique inside agreement. party
        public Guid Id { get; set; } = Guid.NewGuid();
        ///$Management information for object. Refer to: Structure: Element/v1
        public Element Header { get; set; } = new Element();
        ///$Role of contact in agreement. Refer to: Enum: ContactRole/v1
        public ContactRole Role { get; set; } = ContactRole.APPROVER;
        ///$Type of contact from list of contact of the party. Refer to: Enum: ContactType/v1
        public ContactType Type { get; set; } = ContactType.ATTORNEY;
        ///Id of the contact in the list of party contacts. This is optional if specific contact assigned to role in agreement.
        public Guid ContactId { get; set; } = Guid.NewGuid();
    }
}


