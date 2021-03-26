using DotNetGraphQL.Common.Enums;
using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  A set of rules that describe when the event is scheduled.
    ///</summary>
    public class Repeat
    {
        ///$Either a duration for the length of the timing schedule, a range of possible length, or outer bounds for start and/or end limits of the timing schedule.
        /// Refer to: Structure[]: Duration/v1
        public Duration[] Bounds { get; set; } = new Duration[0];
        ///A total count of the desired number of repetitions across the duration of the entire timing specification. If countMax is present, this element indicates the lower bound of the allowed range of count values.
        /// If you have both bounds and count, then this should be understood as within the bounds period, until count times happens.
        public uint Count { get; set; } = 0;
        ///If present, indicates that the count is a range - so to perform the action between [count] and [countMax] times.
        public uint CountMax { get; set; } = 0;
        ///How long this thing happens for when it happens. If durationMax is present, this element indicates the lower bound of the allowed range of the duration.
        ///For some events the duration is part of the definition of the event (e.g. IV infusions, where the duration is implicit in the specified quantity and rate). For others, it's part of the timing specification (e.g. exercise).
        public Decimal Duration { get; set; } = Decimal.Zero;
        ///If present, indicates that the duration is a range - so to perform the action between [duration] and [durationMax] time length.
        ///For some events the duration is part of the definition of the event (e.g. IV infusions, where the duration is implicit in the specified quantity and rate). For others, it's part of the timing specification (e.g. exercise).
        public Decimal DurationMax { get; set; } = Decimal.Zero;
        ///$The units of time for the duration, in UCUM units. Refer to: Enum: UnitsOfTime/v1
        public UnitsOfTime DurationUnit { get; set; } = UnitsOfTime.H;
        ///The number of times to repeat the action within the specified period. If frequencyMax is present, this element indicates the lower bound of the allowed range of the frequency.
        public uint Frequency { get; set; } = 0;
        ///If present, indicates that the frequency is a range - so to repeat between [frequency] and [frequencyMax] times within the period or period range.
        public uint FrequencyMax { get; set; } = 0;
        ///Indicates the duration of time over which repetitions are to occur; e.g. to express /3 times per day/, 3 would be the frequency and "1 day" would be the period. If periodMax is present, this element indicates the lower bound of the allowed range of the period length.
        public Decimal Period { get; set; } = Decimal.Zero;
        ///If present, indicates that the period is a range from [period] to [periodMax], allowing expressing concepts such as "do this once every 3-5 days.
        public Decimal PeriodMax { get; set; } = Decimal.Zero;
        ///$The units of time for the period in UCUM units.
        public UnitsOfTime PeriodUnit { get; set; } = UnitsOfTime.H;
        ///$If one or more days of week is provided, then the action happens only on the specified day(s).
        ///If no days are specified, the action is assumed to happen every day as otherwise specified. The elements frequency and period cannot be used as well as dayOfWeek. Refer to: Enum[]: / WeekDay / v1
        public WeekDay[] DayOfWeek { get; set; } = new WeekDay[0];
        ///(Time type not supported by codegen) The specified time of day for action to take place.
        ///When time of day is specified, it is inferred that the action happens every day (as filtered by dayofWeek) on the specified times. The elements when, frequency and period cannot be used as well as timeOfDay.
        public DateTime[] TimeOfDay { get; set; } = new DateTime[0];
        ///$An approximate time period during the day, potentially linked to an event of daily living that indicates when the action should occur.
        ///When more than one event is listed, the event is tied to the union of the specified events. Refer to: Enum[]: EventTiming / v1
        ///EventTiming[] WhenTiming { get; };
        ///The number of minutes from the event. If the event code does not indicate whether the minutes is before or after the event, then the offset is assumed to be after the event.
        public uint Offset { get; set; } = 0;
        // event time
        public EventTiming WhenTiming { get; set; } = EventTiming.AC;
    }
}


