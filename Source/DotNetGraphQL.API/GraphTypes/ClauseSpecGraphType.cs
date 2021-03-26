using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    /// Component of template. Component can contain clause or other template.
    ///</summary>
    public class ClauseSpecGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.ClauseSpec>
    {
        public ClauseSpecGraphType()
        {
            Field(x => x.Reference).Description(@"Reference to actual clause from catalog.");
        }
    }
}

