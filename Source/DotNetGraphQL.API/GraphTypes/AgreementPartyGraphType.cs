using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   Party of agreement. Party is reference to party resource.
    ///</summary>
    public class AgreementPartyGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.AgreementParty>
    {
        public AgreementPartyGraphType()
        {
            Field(x => x.Id).Description(@"Identity of agreement party must be unique inside agreement.");
            Field<ElementGraphType>("Header", resolve: x => x.Source.Header, description: @"$Management information for action Refer to: Structure: Element/v1");
            Field(x => x.Role).Description(@"Role of the party in agreement. Roles defined by agreement creator. Role must be unique for party inside agreement.");
            Field(x => x.Party).Description(@"Party to reference for agreement participation.");
            Field<ListGraphType<AgreementContactGraphType>>("Contacts", resolve: x => x.Source.Contacts, description: @"$List of contacts to work on party agreement. Refer to: Structure[]: AgreementContact/v1");
        }
    }
}

