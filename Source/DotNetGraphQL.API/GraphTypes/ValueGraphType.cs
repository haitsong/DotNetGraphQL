using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   Value union which can provide different type of measured value.
    ///</summary>
    public class ValueGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.Value>
    {
        public ValueGraphType()
        {
            Field<QuantityGraphType>("ValueQuantity", resolve: x => x.Source.ValueQuantity, description: @"$Value as quantity. Refer to: Structure: Quantity/v1");
            Field<RangeGraphType>("ValueRange", resolve: x => x.Source.ValueRange, description: @"$Value as range of quantities. Refer to: Structure: Range/v1");
            Field<RatioGraphType>("ValueRatio", resolve: x => x.Source.ValueRatio, description: @"$Value as ratio. Refer to: Structure: Ratio/v1");
            Field<PeriodGraphType>("ValuePeriod", resolve: x => x.Source.ValuePeriod, description: @"$Value as time period. Refer to: Structure: Period/v1");
            Field(x => x.ValueString).Description(@"Value as text.");
            Field(x => x.ValueBoolean).Description(@"Value as boolean true/false.");
            Field(x => x.Id).Description(@"Id of the Value (Temporary field)");
        }
    }
}

