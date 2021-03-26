using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   This type is for containing or referencing attachments - additional data content defined in other formats. The most common use of this type is to include images or reports in some report format such as PDF. However it can be used for any data that has a MIME type. http://build.fhir.org//datatypes.html#Attachment
    ///</summary>
    public class AttachmentGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.Attachment>
    {
        public AttachmentGraphType()
        {
            Field(x => x.Id).Description(@"Guid of the attachmentt");
            Field(x => x.ContentType).Description(@"Mime type of the content, with charset etc.");
            Field<LocaleEnum>("Language", resolve: x => x.Source.Language, description: @"$Human language of the content (BCP-47) Refer to: Enum: /Locale/v1");
            Field(x => x.Data).Description(@"Data inline, base64ed");
            Field(x => x.Url).Description(@"Uri where the data can be found");
            Field(x => x.Size).Description(@"Number of bytes of content (if url provided)");
            Field(x => x.Hash).Description(@"Hash of the data (sha-1, base64ed)");
            Field(x => x.Title).Description(@"Label to display in place of the data");
            Field(x => x.Creation).Description(@"Date attachment was first created");
            Field<ElementGraphType>("ElementId", resolve: x => x.Source.ElementId, description: @"$This is id for period element. It is inherit properties from Element structure. Refer to: Structure: Element/v1");
        }
    }
}

