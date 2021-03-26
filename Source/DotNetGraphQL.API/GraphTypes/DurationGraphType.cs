using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   Duration union which can provide different type of time duration values.
    ///</summary>
    public class DurationGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.Duration>
    {
        public DurationGraphType()
        {
            Field(x => x.DurationTimespan).Description(@"Duration as time span.");
            Field<DurationSpecGraphType>("DurationTimeSpec", resolve: x => x.Source.DurationTimeSpec, description: @"$Duration as duration specification by units of time. Refer to: Structure: DurationSpec/v1");
            Field<PeriodGraphType>("DurationPeriod", resolve: x => x.Source.DurationPeriod, description: @"$Duration as period of time defined by specification Refer to: Structure: Period/v1");
            Field<PeriodSpecGraphType>("DurationPeriodSpec", resolve: x => x.Source.DurationPeriodSpec, description: @"$Duration as period of time. Refer to: Structure: PeriodSpec/v1");
            Field<RangeGraphType>("DurationRange", resolve: x => x.Source.DurationRange, description: @"$Range of values for duration. Refer to: Structure: Range/v1");
            Field(x => x.Id).Description(@"Id of Occurence");
        }
    }
}

