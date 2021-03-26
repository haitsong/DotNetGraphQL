using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   A set of ordered Quantity values defined by a low and high limit. 
    /// A Range specifies a set of possible values; usually, one value from the range applies (e.g. "give the patient between 2 and 4 tablets"). Ranges are typically used in instructions. 
    ///</summary>
    public class RangeGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.Range>
    {
        public RangeGraphType()
        {
            Field<QuantityGraphType>("Low", resolve: x => x.Source.Low, description: @"$Low limit Refer to: Structure: Quantity/v1");
            Field<QuantityGraphType>("High", resolve: x => x.Source.High, description: @"$High limit Refer to: Structure: Quantity/v1");
            Field(x => x.Id).Description(@"Id of range (Temporary field)");
        }
    }
}

