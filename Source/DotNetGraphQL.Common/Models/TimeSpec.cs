using DotNetGraphQL.Common.Enums;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Time specification defines reacquiring point in time, when some operation can be executed. Time spec validated against date-time of some moment in time. If moment match specification operation can be executed. Validation happens per every component of specification. Factor applied to component before validation. 
    ///    For example: 
    /// 1. Month-05 means we execute in first hour of first day of May.
    /// 2. Hour 00 means we execute on first hour of every day.
    /// 3.Minute 3 means we execute every third minutes of the hour
    /// 4. Hour 01, Minute 01 - we execute every day in first hour and first minute.
    ///</summary>
    public class TimeSpec
    {
        ///$Specification of month in which bill need to be produced. Refer to: Enum: /Month/v1
        public Month Month { get; set; } = Month.JANUARY;
        ///$Specification for week. Refer to: Enum: /Week/v1
        public Week Week { get; set; } = Week.W01;
        ///$Specification for month day bill need to be produced. Refer to: Enum: /MonthDay/v1
        public MonthDay Day { get; set; } = MonthDay.D01;
        ///$Specification for week day on which bill need to be produced. Refer to: Enum: /WeekDay/v1
        public WeekDay WeekDay { get; set; } = WeekDay.FRIDAY;
        ///$Specification cat off time of day for bill production. Refer to: Enum: /Hour/v1
        public Hour Hour { get; set; } = Hour.H00;
        ///Minute we use to execute. It is number from 0 to 50.
        public ushort Minute { get; set; } = 0;
        ///$This is factors used to modify portion of current date for validation with spec.   Refer to: Structure[]: /TimeFactor/v1
        public TimeFactor[] Factors { get; set; } = new TimeFactor[0];
    }
}


