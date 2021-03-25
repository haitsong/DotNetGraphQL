using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  A relationship between two Quantity values expressed as a numerator and a denominator. 
    /// The Ratio datatype should only be used to express a relationship of two numbers if the relationship cannot be suitably expressed using a Quantity and a common unit. Where the denominator value is known to be fixed to "1", Quantity should be used instead of Ratio. 
    ///</summary>
    public class Ratio
    {
        ///$Numerator value Refer to: Structure: Quantity/v1
        public Quantity Numerator { get; } = new Quantity();
        ///$Denominator value Refer to: Structure: Quantity/v1
        public Quantity Denominator { get; } = new Quantity();
        ///Id of the Ratio (Temporary field)
        public String Id { get; } = string.Empty;
    }
}


