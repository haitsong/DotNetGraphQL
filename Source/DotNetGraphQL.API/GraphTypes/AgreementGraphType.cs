using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   Agreement is a container for all agreement documents.
    ///</summary>
    public class AgreementGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.Agreement>
    {
        public AgreementGraphType()
        {
            Field<IdentityGraphType>("Identity", resolve: x => x.Source.Identity, description: @"$Identity of documents contain globally unique id. Refer to: Structure: /Identity/v1");
            Field<EntityGraphType>("Entity", resolve: x => x.Source.Entity, description: @"$Document is a resource and will be accessible through API. Refer to: Structure: Entity/v1");
            Field<ListGraphType<AgreementPartyGraphType>>("Parties", resolve: x => x.Source.Parties, description: @"$Parties participating in agreement. Refer to: Structure[]: AgreementParty/v1");
        }
    }
}

