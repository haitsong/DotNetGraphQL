using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   Author union which can provide different type of author reference for document.
    ///</summary>
    public class AuthorGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.Author>
    {
        public AuthorGraphType()
        {
            Field(x => x.AuthorReference).Description(@"Reference to author of the document registered in the system as entity.");
            Field(x => x.AuthorString).Description(@"Text information about author not reference in the system.");
        }
    }
}

