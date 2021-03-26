using DotNetGraphQL.Common.Enums;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  A amount of money. Money meagered by sum of currency.
    ///</summary>
    public class Amount
    {
        ///Amount of money
        public Money MoneyAmount { get; set; } = new Money();
        ///$Currency to represent amount of money.  Refer to: Enum: /Currency/v1
        public Currency Currency { get; set; } = Currency.AUD;
    }
}


