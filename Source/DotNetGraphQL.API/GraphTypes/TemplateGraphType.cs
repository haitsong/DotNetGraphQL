using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   Template of agreement. Template specified prototype for agreements. Agreement documents use template to configure actual agreement. Template contains two main parts: attributes and components. Attributes provide specification of configuration parameters for template. Components defines smart clauses document will be assembled from.
    ///</summary>
    public class TemplateGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.Template>
    {
        public TemplateGraphType()
        {
            Field<IdentityGraphType>("Identity", resolve: x => x.Source.Identity, description: @"$Identity of template contains globally unique id. Refer to: Structure: /Identity/v1");
            Field<VersionGraphType>("Version", resolve: x => x.Source.Version, description: @"$Template will have versions, as it will be evolving. Refer to: Structure: /Version/v1");
            Field<EntityGraphType>("Entity", resolve: x => x.Source.Entity, description: @"$Template is a resource and will be accessible through API.  Refer to: Structure: Entity/v1");
            Field(x => x.Parties).Description(@"List of parties recognized by template. Party presented by name. Name of party used to identify party connection to templates clauses..");
            Field<ListGraphType<AttributeGraphType>>("Attributes", resolve: x => x.Source.Attributes, description: @"$List of attributes template required to specify for document. Refer to: Structure[]: Attribute/v1");
            Field<ListGraphType<ComponentGraphType>>("Components", resolve: x => x.Source.Components, description: @"$List of components template assembled from.  Refer to: Structure[]: Component/v1");
        }
    }
}

