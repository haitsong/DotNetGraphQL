using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   Party represents partner account. Agreement can be created between multiple external parties and organizations of current account.
    ///</summary>
    public class PartyGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.Party>
    {
        public PartyGraphType()
        {
            Field<IdentityGraphType>("Identity", resolve: x => x.Source.Identity, description: @"$Identity of parties contain globally unique id. Refer to: Structure: /Identity/v1");
            Field<EntityGraphType>("Entity", resolve: x => x.Source.Entity, description: @"$Party is a resource and will be accessible through API. Refer to: Structure: Entity/v1");
            Field<ListGraphType<ContactGraphType>>("Contacts", resolve: x => x.Source.Contacts, description: @"$List of contacts used for party. Refer to: Structure[]: Contact/v1");
        }
    }
}

