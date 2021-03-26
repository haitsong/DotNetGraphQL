using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   Contact information for object support.
    ///</summary>
    public class ContactGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.Contact>
    {
        public ContactGraphType()
        {
            Field<IdentityGraphType>("Identity", resolve: x => x.Source.Identity, description: @"$Identity of organization or person. Refer to: Structure: /Identity");
            Field(x => x.URL).Description(@"The URL pointing to the contact information.");
            Field(x => x.EMail).Description(@"The email address of the contact person/organization.");
        }
    }
}

