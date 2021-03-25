using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  A set of ordered Quantity values defined by a low and high limit. 
    ///  A Range specifies a set of possible values; usually, one value from the range applies (e.g. "give the patient between 2 and 4 tablets"). Ranges are typically used in instructions. 
    ///</summary>
    public class Range
    {
        ///$Low limit Refer to: Structure: Quantity/v1
        public Quantity Low { get; } = new Quantity();
        ///$High limit Refer to: Structure: Quantity/v1
        public Quantity High { get; } = new Quantity();
        ///Id of range (Temporary field)
        public String Id { get; } = string.Empty;
    }
}


