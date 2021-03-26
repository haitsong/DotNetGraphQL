using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   Schema for the clause data.
    ///</summary>
    public class ClauseSchemaGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.ClauseSchema>
    {
        public ClauseSchemaGraphType()
        {
            Field<IdentityGraphType>("Identity", resolve: x => x.Source.Identity, description: @"$Shema have globally unique id. Refer to: Structure: /Identity/v1");
            Field<VersionGraphType>("Version", resolve: x => x.Source.Version, description: @"$Clause will have versions, as it will be evolving. Refer to: Structure: /Version/v1");
            Field<EntityGraphType>("Entity", resolve: x => x.Source.Entity, description: @"$Schema is a resource and will be accessible through API.  Refer to: Structure: Entity/v1");
            Field<ListGraphType<AttributeGraphType>>("Attributes", resolve: x => x.Source.Attributes, description: @"$Attributes of the schema Refer to: Structure[]: Attribute/v1");
        }
    }
}

