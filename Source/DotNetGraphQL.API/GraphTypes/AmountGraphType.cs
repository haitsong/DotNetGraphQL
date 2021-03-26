using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   A amount of money. Money meagered by sum of currency.
    ///</summary>
    public class AmountGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.Amount>
    {
        public AmountGraphType()
        {
            Field(x => x.MoneyAmount).Description(@"Amount of money");
            Field<CurrencyEnum>("Currency", resolve: x => x.Source.Currency, description: @"$Currency to represent amount of money.  Refer to: Enum: /Currency/v1");
        }
    }
}

