using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   A text note which also contains information about who made the statement and when. http://build.fhir.org//datatypes.html#Attachment
    ///</summary>
    public class AnnotationGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.Annotation>
    {
        public AnnotationGraphType()
        {
            Field(x => x.Id).Description(@"This is id for note element. ");
            Field<ElementGraphType>("Header", resolve: x => x.Source.Header, description: @"$This is header for note , containing information for record management. Refer to: Structure: Element/v1");
            Field<AuthorGraphType>("Author", resolve: x => x.Source.Author, description: @"$Individual responsible for the annotation Refer to: Structure: Author/v1");
            Field(x => x.Text).Description(@"The annotation - text content (as markdown)");
        }
    }
}

