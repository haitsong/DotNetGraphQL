using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   A amount of money to pay per quantity of service or product..
    ///</summary>
    public class PriceGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.Price>
    {
        public PriceGraphType()
        {
            Field(x => x.Id).Description(@"Guid of the price");
            Field<AmountGraphType>("Amount", resolve: x => x.Source.Amount, description: @"$Amount of money to pay. Refer to: Structure: Amount/v1");
            Field<QuantityGraphType>("Quantity", resolve: x => x.Source.Quantity, description: @"$Quantity of service or product. By default it is one instance. Refer to: Structure: Quantity/v1");
        }
    }
}

