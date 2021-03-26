using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Value union which can provide different type of measured value.
    ///</summary>
    public class Value
    {
        ///$Value as quantity. Refer to: Structure: Quantity/v1
        public Quantity ValueQuantity { get; set; } = new Quantity();
        ///$Value as range of quantities. Refer to: Structure: Range/v1
        public Range ValueRange { get; set; } = new Range();
        ///$Value as ratio. Refer to: Structure: Ratio/v1
        public Ratio ValueRatio { get; set; } = new Ratio();
        ///$Value as time period. Refer to: Structure: Period/v1
        public Period ValuePeriod { get; set; } = new Period();
        ///Value as text.
        public String ValueString { get; set; } = string.Empty;
        ///Value as boolean true/false.
        public Boolean ValueBoolean { get; set; } = false;
        ///Id of the Value (Temporary field)
        public String Id { get; set; } = string.Empty;
    }
}


