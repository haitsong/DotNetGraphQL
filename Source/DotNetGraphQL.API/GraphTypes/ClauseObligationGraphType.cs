using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   Obligation for one of clause's party. Obligation will be activated on event and provide information associated with it. 
    ///</summary>
    public class ClauseObligationGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.ClauseObligation>
    {
        public ClauseObligationGraphType()
        {
            Field(x => x.Id).Description(@"Identity of obligation inside clause event..");
            Field<ElementGraphType>("Header", resolve: x => x.Source.Header, description: @"$Management information for clause obligation Refer to: Structure: Element/v1");
            Field(x => x.Party).Description(@"Name of clause party associated with obligation.");
            Field<ObligationGraphType>("Obligations", resolve: x => x.Source.Obligations, description: @"Reference to obligation defined in catalog.");
        }
    }
}

