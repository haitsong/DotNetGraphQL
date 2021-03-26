using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   
    ///</summary>
    public class PersonGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.Person>
    {
        public PersonGraphType()
        {
            Field(x => x.Id).Description(@"");
            Field(x => x.LastName).Description(@"");
            Field(x => x.FirstName).Description(@"");
            Field(x => x.Email).Description(@"");
            Field(x => x.Department).Description(@"");
            Field(x => x.Phone).Description(@"");
            Field(x => x.OrganizationId).Description(@"The organization employing the individual (optional)");
            Field<ListGraphType<AddressGraphType>>("Addresses", resolve: x => x.Source.Addresses, description: @"$ Refer to: Structure[]: Address/v1");
        }
    }
}

