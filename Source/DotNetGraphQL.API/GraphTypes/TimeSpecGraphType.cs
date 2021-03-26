using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   Time specification defines reacquiring point in time, when some operation can be executed. Time spec validated against date-time of some moment in time. If moment match specification operation can be executed. Validation happens per every component of specification. Factor applied to component before validation. 
    ///For example: 
    ///1.Month - 05 means we execute in first hour of first day of May.
    ///2. Hour 00 means we execute on first hour of every day.
    ///3.Minute 3 means we execute every third minutes of the hour
    ///4. Hour 01, Minute 01 - we execute every day in first hour and first minute.
    ///</summary>
    public class TimeSpecGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.TimeSpec>
    {
        public TimeSpecGraphType()
        {
            Field<MonthEnum>("Month", resolve: x => x.Source.Month, description: @"$Specification of month in which bill need to be produced. Refer to: Enum: /Month/v1");
            Field<WeekEnum>("Week", resolve: x => x.Source.Week, description: @"$Specification for week. Refer to: Enum: /Week/v1");
            Field<MonthDayEnum>("Day", resolve: x => x.Source.Day, description: @"$Specification for month day bill need to be produced. Refer to: Enum: /MonthDay/v1");
            Field<WeekDayEnum>("WeekDay", resolve: x => x.Source.WeekDay, description: @"$Specification for week day on which bill need to be produced. Refer to: Enum: /WeekDay/v1");
            Field<HourEnum>("Hour", resolve: x => x.Source.Hour, description: @"$Specification cat off time of day for bill production. Refer to: Enum: /Hour/v1");
            Field(x => x.Minute).Description(@"Minute we use to execute. It is number from 0 to 50.");
            Field<ListGraphType<TimeFactorGraphType>>("Factors", resolve: x => x.Source.Factors, description: @"$This is factors used to modify portion of current date for validation with spec.   Refer to: Structure[]: /TimeFactor/v1");
        }
    }
}

