using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   Structure to maintain value of specific type.
    ///</summary>
    public class VariantGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.Variant>
    {
        public VariantGraphType()
        {
            Field(x => x.Value).Description(@"Value of type variant maintained.");
        }
    }
}

