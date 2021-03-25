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
        public Decimal Value { get; } = Decimal.Zero;
        ///$How to understand the value Refer to: Enum: QuantityComparator/v1
        public QuantityComparator Comparator { get; } = QuantityComparator.EQ;
        ///Unit representation
        public String Unit { get; } = string.Empty;
        ///System that defines coded unit form
        public String System { get; } = string.Empty;
        ///Coded form of the unit
        public String Code { get; } = string.Empty;
        ///Id of the Quantity (Temporary field)
        public String Id { get; } = string.Empty;
    }
}


