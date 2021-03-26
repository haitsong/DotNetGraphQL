using DotNetGraphQL.Common.Enums;
using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Specification for time period. Specification used to define reacquiring period of time.
    ///</summary>
    public class PeriodSpec
    {
        ///First year of period specification.
        public short YearStart { get; set; } = 0;
        ///Last year of specified period.
        public short YearEnd { get; set; } = 0;
        ///$First month of the period. Refer to: Enum: /Month/v1
        public Month MonthStart { get; set; } = Month.JANUARY;
        ///$Last month of the period. Refer to: Enum: /Month/v1
        public Month MonthEnd { get; set; } = Month.JANUARY;
        ///$First day of month of the period. Refer to: Enum: /MonthDay/v1
        public MonthDay MonthDayStart { get; set; } = MonthDay.D01;
        ///$Last day of month of the period. Refer to: Enum: /MonthDay/v1
        public MonthDay MonthDayEnd { get; set; } = MonthDay.D01;
        ///$First week of the period. Refer to: Enum: /Week/v1
        public Week WeekStart { get; set; } = Week.W01;
        ///$Last week of the period. Refer to: Enum: /Week/v1
        public Week WeekEnd { get; set; } = Week.W01;
        ///$First day of week of the period. Refer to: Enum: /WeekDay/v1
        public WeekDay WeekDayStart { get; set; } = WeekDay.FRIDAY;
        ///$Last day of week of the period. Refer to: Enum: /WeekDay/v1
        public WeekDay WeekDayEnd { get; set; } = WeekDay.FRIDAY;
        ///Initial time of time period.
        public DateTime TimeStart { get; set; } = DateTime.MinValue;
        ///Final time of time period.
        public DateTime TimeEnd { get; set; } = DateTime.MinValue;
    }
}


