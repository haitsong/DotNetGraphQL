using System;
using DotNetGraphQL.Common.Enums;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  A measured amount (or an amount that can potentially be measured). 
    ///</summary>
    public class Quantity
    {
        ///Numerical value (with implicit precision)
        public Decimal Value { get; set; } = Decimal.Zero;
        ///$How to understand the value Refer to: Enum: QuantityComparator/v1
        public QuantityComparator Comparator { get; set; } = QuantityComparator.EQ;
        ///Unit representation
        public String Unit { get; set; } = string.Empty;
        ///System that defines coded unit form
        public String System { get; set; } = string.Empty;
        ///Coded form of the unit
        public String Code { get; set; } = string.Empty;
        ///Id of the Quantity (Temporary field)
        public String Id { get; set; } = string.Empty;
    }
}


