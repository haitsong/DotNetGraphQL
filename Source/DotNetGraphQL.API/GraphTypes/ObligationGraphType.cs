using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   Obligation defined by clause. Obligation will be fired when event associated with it fired up.
    ///</summary>
    public class ObligationGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.Obligation>
    {
        public ObligationGraphType()
        {
            Field<IdentityGraphType>("Identity", resolve: x => x.Source.Identity, description: @"$Obligation have globally unique id. Refer to: Structure: /Identity/v1");
            Field<VersionGraphType>("Version", resolve: x => x.Source.Version, description: @"$Clause will have versions, as it will be evolving. Refer to: Structure: /Version/v1");
            Field<EntityGraphType>("Entity", resolve: x => x.Source.Entity, description: @"$Schema is a resource and will be accessible through API.  Refer to: Structure: Entity/v1");
            Field<ListGraphType<AttributeGraphType>>("Attributes", resolve: x => x.Source.Attributes, description: @"$Attributes of the schema Refer to: Structure[]: Attribute/v1");
        }
    }
}

