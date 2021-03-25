using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  A amount of money to pay per quantity of service or product..
    ///</summary>
    public class Price
    {
        ///Guid of the price
        public Guid Id { get; } = Guid.Empty;
        ///$Amount of money to pay. Refer to: Structure: Amount/v1
        public Amount Amount { get; } = new Amount();
        ///$Quantity of service or product. By default it is one instance. Refer to: Structure: Quantity/v1
        public Quantity Quantity { get; } = new Quantity();
    }
}


