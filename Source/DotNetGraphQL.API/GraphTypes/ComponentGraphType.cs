using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   Component of template. Component can contain clause or other template.
    ///</summary>
    public class ComponentGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.Component>
    {
        public ComponentGraphType()
        {
            Field(x => x.Id).Description(@"Identity of component must be unique inside template.");
            Field<ElementGraphType>("Header", resolve: x => x.Source.Header, description: @"$Management information for component Refer to: Structure: Element/v1");
            Field<ComponentTypeEnum>("Type", resolve: x => x.Source.Type, description: @"$Type of component defines it use clause or other template. Refer to: Enum: ComponentType/v1");
            Field<ListGraphType<ComponentPartyGraphType>>("Parties", resolve: x => x.Source.Parties, description: @"$List of parties used in component. Refer to: Structure[]: ComponentParty/v1");
            Field<ComponentSpecGraphType>("Specification", resolve: x => x.Source.Specification, description: @"$Reference to actual template or clause from catalog. Refer to: Structure: ComponentSpec/v1");
            Field(x => x.Dataset).Description(@"Specification of values for clause or template attributes. Reference  to attributes of current template attributes can be used to configure clause or template.");
        }
    }
}

