using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   Addresses for people and organizations.
    ///</summary>
    public class AddressGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.Address>
    {
        public AddressGraphType()
        {
            Field(x => x.StreetAddress).Description(@"A new description");
            Field(x => x.City).Description(@"city");
            Field(x => x.Country).Description(@"county");
            Field(x => x.State).Description(@"state");
            Field(x => x.ZipOrPostalCode).Description(@"zipcode or postal code");
        }
    }
}

