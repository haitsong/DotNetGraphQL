using GraphQL.Types;
using DotNetGraphQL.Common.Models;

namespace DotNetGraphQL.API
{
    public class ClauseInputType : InputObjectGraphType<Clause>
    {
        public ClauseInputType()
        {
            Name = "ClauseInput";
            Description = "Specification of clause component in catalog. Clause contains specification for schema and rendering.";
            Field<IdentityGraphType>("Identity", resolve: x => x.Source.Identity, description: @"$Clause have globally unique id. Refer to: Structure: /Identity/v1");
            Field<VersionGraphType>("Version", resolve: x => x.Source.Version, description: @"$Clause will have versions, as it will be evolving. Refer to: Structure: /Version/v1");
            Field<EntityGraphType>("Entity", resolve: x => x.Source.Entity, description: @"$Clause is a resource and will be accessible through API.  Refer to: Structure: Entity/v1");
            Field(x => x.Parties).Description(@"List of parties recognized by clause. Party presented by name. Name of party used to identify party obligations.");
            Field<ListGraphType<AttributeGraphType>>("Attributes", resolve: x => x.Source.Attributes, description: @"$Clause list of attributes, which defines clause schema. Refer to: Structure[]: Attribute/v1");
            Field<ListGraphType<EventGraphType>>("Events", resolve: x => x.Source.Events, description: @"$List of events supported by clause. Refer to: Structure[]: Event/v1");
        }
    }
}
