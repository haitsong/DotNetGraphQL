using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Party of agreement. Party is reference to party resource.
    ///</summary>
    public class AgreementParty
    {
        ///Identity of agreement party must be unique inside agreement.
        public Guid Id { get; } = Guid.NewGuid();
        ///$Management information for action Refer to: Structure: Element/v1
        public Element Header { get; } = new Element();
        ///Role of the party in agreement. Roles defined by agreement creator. Role must be unique for party inside agreement.
        public String Role { get; } = string.Empty;
        ///Party to reference for agreement participation.
        public Party Party { get; } = new Party();
        ///$List of contacts to work on party agreement. Refer to: Structure[]: AgreementContact/v1
        public AgreementContact[] Contacts { get; } = new AgreementContact[0];
    }
}


