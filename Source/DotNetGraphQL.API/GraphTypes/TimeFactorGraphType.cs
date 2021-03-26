using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   Factor for time specification. Factor apply to current time components before compare with specification. For example for day 05/09/2017 is a day 9 of May. With factor 2 for Daily, we will divide it to 2 and compare remains to Month Day spec. If our spec defines execute on first day of month, and factor is 2, we will execute every second day of month.
    ///</summary>
    public class TimeFactorGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.TimeFactor>
    {
        public TimeFactorGraphType()
        {
            Field<FrequencyEnum>("Component", resolve: x => x.Source.Component, description: @"$Component of date factor apply to. Refer to: Enum: /Frequency/v1");
            Field(x => x.Value).Description(@"Value of factor to apply.");
        }
    }
}

