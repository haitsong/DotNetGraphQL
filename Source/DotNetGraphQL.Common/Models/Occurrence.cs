using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Occurrence union which can provide different type of time values.
    ///</summary>
    public class Occurrence
    {
        ///$occurrence as period of time. Refer to: Structure: Period/v1
        public Period OccurrencePeriod { get; set; } = new Period();
        ///$Range of values for occurance. Refer to: Structure: Range/v1
        public Range OccuranceRange { get; set; } = new Range();
        ///Occurrence as point in time.
        public DateTime OccurrenceDateTime { get; set; } = DateTime.MaxValue;
        ///$Occurrence as point in time. Refer to: Structure: Timing/v1
        public Timing OccurrenceTiming { get; set; } = new Timing();
        ///Id of Occurence
        public String Id { get; set; } = string.Empty;
    }
}


