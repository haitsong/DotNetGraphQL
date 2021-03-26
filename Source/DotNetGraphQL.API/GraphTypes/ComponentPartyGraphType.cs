using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   Party of component of template. Party map template and document party to parties of clause or template in component..
    ///</summary>
    public class ComponentPartyGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.ComponentParty>
    {
        public ComponentPartyGraphType()
        {
            Field(x => x.Id).Description(@"Name of clause or template party inside component. This is party name specified in actual clause or template reference by component. ");
            Field<ElementGraphType>("Header", resolve: x => x.Source.Header, description: @"$Management information for component party. Refer to: Structure: Element/v1");
            Field(x => x.Party).Description(@"Reference to actual party of template or document by name of the party/.");
            Field(x => x.Dataset).Description(@"Specification of values for the party as it presented in component on time of document creation..");
        }
    }
}

