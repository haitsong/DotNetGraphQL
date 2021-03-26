using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   A measured amount (or an amount that can potentially be measured). 
    ///</summary>
    public class QuantityGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.Quantity>
    {
        public QuantityGraphType()
        {
            Field(x => x.Value).Description(@"Numerical value (with implicit precision)");
            Field<QuantityComparatorEnum>("Comparator", resolve: x => x.Source.Comparator, description: @"$How to understand the value Refer to: Enum: QuantityComparator/v1");
            Field(x => x.Unit).Description(@"Unit representation");
            Field(x => x.System).Description(@"System that defines coded unit form");
            Field(x => x.Code).Description(@"Coded form of the unit");
            Field(x => x.Id).Description(@"Id of the Quantity (Temporary field)");
        }
    }
}

