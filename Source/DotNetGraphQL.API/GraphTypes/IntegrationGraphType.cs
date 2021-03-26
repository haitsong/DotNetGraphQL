using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   Integration of template with enterprise internal and external systems. Template can have multiple integrations designed for different set of systems. When document created, integration relevant for party will be used.
    ///</summary>
    public class IntegrationGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.Integration>
    {
        public IntegrationGraphType()
        {
            Field<IdentityGraphType>("Identity", resolve: x => x.Source.Identity, description: @"$Identity of integration contains globally unique id. Refer to: Structure: /Identity/v1");
            Field<VersionGraphType>("Version", resolve: x => x.Source.Version, description: @"$Integration will have versions, as it will be evolving. Refer to: Structure: /Version/v1");
            Field<EntityGraphType>("Entity", resolve: x => x.Source.Entity, description: @"$Integration is a resource and will be accessible through API. Parent for Integration is a Template.   Refer to: Structure: Entity/v1");
            Field(x => x.Party).Description(@"Party of template, integration is applicable for.");
            Field<ListGraphType<AttributeGraphType>>("Attributes", resolve: x => x.Source.Attributes, description: @"$List of attributes template required to specify for document. Refer to: Structure[]: Attribute/v1");
            Field<ListGraphType<ActionGraphType>>("Actions", resolve: x => x.Source.Actions, description: @"$List of actions implemented in template. Refer to: Structure[]: Action/v1");
        }
    }
}

