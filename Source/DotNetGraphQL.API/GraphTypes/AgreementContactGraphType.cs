using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   Contact of agreement Party. Contact reference to party contact by type or id.
    ///</summary>
    public class AgreementContactGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.AgreementContact>
    {
        public AgreementContactGraphType()
        {
            Field(x => x.Id).Description(@"Identity of agreement party contact must be unique inside agreement. party");
            Field<ElementGraphType>("Header", resolve: x => x.Source.Header, description: @"$Management information for object. Refer to: Structure: Element/v1");
            Field<ContactRoleEnum>("Role", resolve: x => x.Source.Role, description: @"$Role of contact in agreement. Refer to: Enum: ContactRole/v1");
            Field<ContactTypeEnum>("Type", resolve: x => x.Source.Type, description: @"$Type of contact from list of contact of the party. Refer to: Enum: ContactType/v1");
            Field(x => x.ContactId).Description(@"Id of the contact in the list of party contacts. This is optional if specific contact assigned to role in agreement.");
        }
    }
}

