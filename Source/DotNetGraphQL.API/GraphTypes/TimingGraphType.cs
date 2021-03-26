using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   Specifies an event that may occur multiple times. Timing schedules are used to record when things are planned, expected or requested to occur. The most common usage is in dosage instructions for medications. They are also used when planning care of various kinds, and may be used for reporting the schedule to which past regular activities were carried out.
    /// Describes the occurrence of an event that may occur multiple times. Timing schedules are used for specifying when events are expected or requested to occur, and may also be used to represent the summary of a past or ongoing event. For simplicity, the definitions of Timing components are expressed as 'future' events, but such components can also be used to describe historic or ongoing events.
    /// A Timing schedule can be a list of events and/or criteria for when the event happens, which can be expressed in a structured form and/or as a code. When both event and a repeating specification are provided, the list of events should be understood as an interpretation of the information in the repeat structure.
    ///</summary>
    public class TimingGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.Timing>
    {
        public TimingGraphType()
        {
            Field(x => x.Event).Description(@"Identifies specific times when the event occurs. (Note. due to codegen limitations, single event per timing was set) ");
            Field<RepeatGraphType>("Repeat", resolve: x => x.Source.Repeat, description: @"$A set of rules that describe when the event is scheduled. Refer to: Structure: Repeat/v1");
            Field<TimingAbbreviationEnum>("Code", resolve: x => x.Source.Code, description: @"$A code for the timing schedule (or just text in code.text). Some codes such as BID are ubiquitous, but many institutions define their own additional codes. If a code is provided, the code is understood to be a complete statement of whatever is specified in the structured timing data, and either the code or the data may be used to interpret the Timing, with the exception that .repeat.bounds still applies over the code (and is not contained in the code).
BID etc. are defined as 'at institutionally specified times'. For example, an institution may choose that BID is /always at 7am and 6pm/. If it is inappropriate for this choice to be made, the code BID should not be used. Instead, a distinct organization-specific code should be used in place of the HL7-defined BID code and/or a structured representation should be used (in this case, specifying the two event times). Refer to: Enum: TimingAbbreviation/v1");
        }
    }
}

