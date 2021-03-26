using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   Attribute of the schema
    ///</summary>
    public class AttributeGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.Attribute>
    {
        public AttributeGraphType()
        {
            Field<IdentityGraphType>("Identity", resolve: x => x.Source.Identity, description: @"$Identity of the attribute. Refer to: Structure: /Identity");
            Field(x => x.Ordinal).Description(@"Position of attribute  in the list. ");
            Field(x => x.Count).Description(@"Number of value for attribute. By default it is one, it means attribute is single value. When count set to 0, it is array of values of undefined size. All other numbers defines fixed size for array.");
            Field(x => x.Type).Description(@"$Type of attributes. Let's use system types for now. Refer to: Enum: /Type/v1");
            Field<ClauseSchemaGraphType>("Reference", resolve: x => x.Source.Reference, description: @"Reference is URI of other schema.");
            Field(x => x.Default).Description(@"Default value for attribute.");
            Field(x => x.Format).Description(@"Format for attribute value. Default value must be presented in specified format.");
        }
    }
}

