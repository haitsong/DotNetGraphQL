using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  A text note which also contains information about who made the statement and when. 
    /// http://build.fhir.org//datatypes.html#Attachment
    ///</summary>
    public class Annotation
    {
        ///This is id for note element. 
        public Guid Id { get; } = Guid.Empty;
        ///$This is header for note , containing information for record management. Refer to: Structure: Element/v1
        public Element Header { get; } = new Element();
        ///$Individual responsible for the annotation Refer to: Structure: Author/v1
        public Author Author { get; } = new Author();
        ///The annotation - text content (as markdown)
        public String Text { get; } = string.Empty;
    }
}


