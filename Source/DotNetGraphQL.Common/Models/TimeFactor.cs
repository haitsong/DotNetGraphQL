using DotNetGraphQL.Common.Enums;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Factor for time specification. Factor apply to current time components before compare with specification. For example for day 05/09/2017 is a day 9 of May. With factor 2 for Daily, we will divide it to 2 and compare remains to Month Day spec. If our spec defines execute on first day of month, and factor is 2, we will execute every second day of month.
    ///</summary>
    public class TimeFactor
    {
        ///$Component of date factor apply to. Refer to: Enum: /Frequency/v1
        public Frequency Component { get; set; } = Frequency.DAILY;
        ///Value of factor to apply.
        public short Value { get; set; } = 0;
    }
}


