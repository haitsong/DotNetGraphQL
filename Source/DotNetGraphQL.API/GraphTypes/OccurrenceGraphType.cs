using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   Occurrence union which can provide different type of time values.
    ///</summary>
    public class OccurrenceGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.Occurrence>
    {
        public OccurrenceGraphType()
        {
            Field<PeriodGraphType>("OccurrencePeriod", resolve: x => x.Source.OccurrencePeriod, description: @"$occurrence as period of time. Refer to: Structure: Period/v1");
            Field<RangeGraphType>("OccuranceRange", resolve: x => x.Source.OccuranceRange, description: @"$Range of values for occurance. Refer to: Structure: Range/v1");
            Field(x => x.OccurrenceDateTime).Description(@"Occurrence as point in time.");
            Field<TimingGraphType>("OccurrenceTiming", resolve: x => x.Source.OccurrenceTiming, description: @"$Occurrence as point in time. Refer to: Structure: Timing/v1");
            Field(x => x.Id).Description(@"Id of Occurence");
        }
    }
}

