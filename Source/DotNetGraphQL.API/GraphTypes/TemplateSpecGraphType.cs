using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   Component of template. Component can contain clause or other template.
    ///</summary>
    public class TemplateSpecGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.TemplateSpec>
    {
        public TemplateSpecGraphType()
        {
            Field(x => x.Id).Description(@"Guid");
            Field<TemplateGraphType>("Reference", resolve: x => x.Source.Reference, description:@"Reference to actual template or clause from catalog.");
            Field<ListGraphType<ComponentGraphType>>("Components", resolve: x => x.Source.Components, description:@"List of components template build from.");
        }
    }
}

