using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   Component of template. Component can contain clause or other template.
    ///</summary>
    public class ComponentSpecGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.ComponentSpec>
    {
        public ComponentSpecGraphType()
        {
            Field<ListGraphType<ClauseSpecGraphType>>("Clauses", resolve: x => x.Source.Clauses, description: @"Reference to actual clause from clause catalog.");
            Field<TemplateSpecGraphType>("Template", resolve: x => x.Source.Template, description: @"Reference to actual template from template catalog.");
        }
    }
}

