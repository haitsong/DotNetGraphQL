using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    /// A relationship between two Quantity values expressed as a numerator and a denominator. 
    /// The Ratio datatype should only be used to express a relationship of two numbers if the relationship cannot be suitably expressed using a Quantity and a common unit. Where the denominator value is known to be fixed to "1", Quantity should be used instead of Ratio. 
    ///</summary>
    public class RatioGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.Ratio>
    {
        public RatioGraphType()
        {
            Field<QuantityGraphType>("Numerator", resolve: x => x.Source.Numerator, description: @"$Numerator value Refer to: Structure: Quantity/v1");
            Field<QuantityGraphType>("Denominator", resolve: x => x.Source.Denominator, description: @"$Denominator value Refer to: Structure: Quantity/v1");
            Field(x => x.Id).Description(@"Id of the Ratio (Temporary field)");
        }
    }
}

