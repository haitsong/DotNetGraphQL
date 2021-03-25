using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Author union which can provide different type of author reference for document.
    ///</summary>
    public class Author
    {
        ///Reference to author of the document registered in the system as entity.
        public Identity AuthorReference { get; } = new Identity();
        ///Text information about author not reference in the system.
        public String AuthorString { get; } = string.Empty;
    }
}


