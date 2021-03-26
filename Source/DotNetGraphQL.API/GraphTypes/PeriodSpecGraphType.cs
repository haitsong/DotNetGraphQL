using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   Specification for time period. Specification used to define reacquiring period of time.
    ///</summary>
    public class PeriodSpecGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.PeriodSpec>
    {
        public PeriodSpecGraphType()
        {
            Field(x => x.YearStart).Description(@"First year of period specification.");
            Field(x => x.YearEnd).Description(@"Last year of specified period.");
            Field<MonthEnum>("MonthStart", resolve: x => x.Source.MonthStart, description: @"$First month of the period. Refer to: Enum: /Month/v1");
            Field<MonthEnum>("MonthEnd", resolve: x => x.Source.MonthEnd, description: @"$Last month of the period. Refer to: Enum: /Month/v1");
            Field<MonthDayEnum>("MonthDayStart", resolve: x => x.Source.MonthDayStart, description: @"$First day of month of the period. Refer to: Enum: /MonthDay/v1");
            Field<MonthDayEnum>("MonthDayEnd", resolve: x => x.Source.MonthDayEnd, description: @"$Last day of month of the period. Refer to: Enum: /MonthDay/v1");
            Field<WeekEnum>("WeekStart", resolve: x => x.Source.WeekStart, description: @"$First week of the period. Refer to: Enum: /Week/v1");
            Field<WeekEnum>("WeekEnd", resolve: x => x.Source.WeekEnd, description: @"$Last week of the period. Refer to: Enum: /Week/v1");
            Field<WeekDayEnum>("WeekDayStart", resolve: x => x.Source.WeekDayStart, description: @"$First day of week of the period. Refer to: Enum: /WeekDay/v1");
            Field<WeekDayEnum>("WeekDayEnd", resolve: x => x.Source.WeekDayEnd, description: @"$Last day of week of the period. Refer to: Enum: /WeekDay/v1");
            Field(x => x.TimeStart).Description(@"Initial time of time period.");
            Field(x => x.TimeEnd).Description(@"Final time of time period.");
        }
    }
}

