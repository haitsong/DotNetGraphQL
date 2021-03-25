using DotNetGraphQL.Common.Enums;
using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Party represents partner account. Agreement can be created between multiple external parties and organizations of current account.
    ///</summary>
    public class Party
    {
        ///$Identity of parties contain globally unique id. Refer to: Structure: /Identity/v1
        public Identity Identity { get; } = new Identity();
        ///$Party is a resource and will be accessible through API. Refer to: Structure: Entity/v1
        public Entity Entity { get; } = new Entity();
        ///$List of contacts used for party. Refer to: Structure[]: Contact/v1
        public Contact[] Contacts { get; } = new Contact[0];
        ///Identifier of Organization associated with an agreement document.
        public String OrganizationID { get; } = string.Empty;
        ///Identifies the person associated with the agreement
        public String PersonId { get; } = string.Empty;
        ///The address used by the party for the associated agreement document.
        public String AddressId { get; } = string.Empty;
        ///$Indicates whether the party is an individual, organization, or a representative. Refer to: Enum: PartyType/v1
        public PartyType PartyType { get; } = PartyType.INDIVIDUAL;
    }
}


