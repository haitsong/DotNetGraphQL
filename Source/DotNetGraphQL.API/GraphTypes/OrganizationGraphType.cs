using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   
    ///</summary>
    public class OrganizationGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.Organization>
    {
        public OrganizationGraphType()
        {
            Field(x => x.OrganizationId).Description(@"");
            Field(x => x.Name).Description(@"");
            Field(x => x.Description).Description(@"");
            Field<ListGraphType<AddressGraphType>>("Addresses", resolve: x => x.Source.Addresses, description: @"$Valid addresses used by the organization Refer to: Structure[]: Address/v1");
        }
    }
}

