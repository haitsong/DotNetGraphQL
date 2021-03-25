using DotNetGraphQL.Common.Enums;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  A time period defined by number of time units. 

    ///</summary>
    public class DurationSpec
    {
        ///Number of time units used for period.
        public float Value { get; } = 0;
        ///$Time units to define duration. Refer to: Enum: UnitsOfTime/v1
        public UnitsOfTime Units { get; } = UnitsOfTime.H;
    }
}


