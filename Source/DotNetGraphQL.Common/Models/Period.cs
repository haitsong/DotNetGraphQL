using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  A time period defined by a start and end date/time. 
    /// A period specifies a range of times. The context of use will specify whether the entire range applies (e.g. "the patient was an inpatient of the hospital for this time range") or one value from the period applies (e.g. "give to the patient between 2 and 4 pm on 24-Jun 2013"). This is simple period used not as part of array of elements.
    ///</summary>
    public class Period
    {
        ///Starting time with inclusive boundary
        public DateTime Start { get; set; } = DateTime.MaxValue;
        ///End time with inclusive boundary, if not ongoing.
        public DateTime End { get; set; } = DateTime.MinValue;
    }
}


