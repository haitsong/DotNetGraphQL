using DotNetGraphQL.Common.Enums;
using System;

namespace DotNetGraphQL.Common.Models
{


    ///<summary>
    ///  This type is for containing or referencing attachments - additional data content defined in other formats. The most common use of this type is to include images or reports in some report format such as PDF. However it can be used for any data that has a MIME type.
    /// http://build.fhir.org//datatypes.html#Attachment
    ///</summary>
    public class Attachment
    {
        ///Guid of the attachmentt
        public Guid Id { get; } = Guid.Empty;
        ///Mime type of the content, with charset etc.
        public String ContentType { get; } = string.Empty;
        ///$Human language of the content (BCP-47) Refer to: Enum: /Locale/v1
        public Locale Language { get; } = Locale.EN_US;
        ///Data inline, base64ed
        public String Data { get; } = string.Empty;
        ///Uri where the data can be found
        public String Url { get; } = string.Empty;
        ///Number of bytes of content (if url provided)
        public uint Size { get; } = 0;
        ///Hash of the data (sha-1, base64ed)
        public String Hash { get; } = string.Empty;
        ///Label to display in place of the data
        public String Title { get; } = string.Empty;
        ///Date attachment was first created
        public DateTime Creation { get; } = DateTime.MinValue;
        ///$This is id for period element. It is inherit properties from Element structure. Refer to: Structure: Element/v1
        public Element ElementId { get; } = new Element();
    }
}


