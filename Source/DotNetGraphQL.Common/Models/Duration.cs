using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Duration union which can provide different type of time duration values.
    ///</summary>
    public class Duration
    {
        ///Duration as time span.
        public TimeSpan DurationTimespan { get; } = TimeSpan.Zero;
        ///$Duration as duration specification by units of time. Refer to: Structure: DurationSpec/v1
        public DurationSpec DurationTimeSpec { get; } = new DurationSpec();
        ///$Duration as period of time defined by specification Refer to: Structure: Period/v1
        public Period DurationPeriod { get; } = new Period();
        ///$Duration as period of time. Refer to: Structure: PeriodSpec/v1
        public PeriodSpec DurationPeriodSpec { get; } = new PeriodSpec();
        ///$Range of values for duration. Refer to: Structure: Range/v1
        public Range DurationRange { get; } = new Range();
        ///Id of Occurence
        public String Id { get; } = string.Empty;
    }
}


