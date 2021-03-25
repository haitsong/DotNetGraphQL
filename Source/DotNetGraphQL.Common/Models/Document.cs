using System;
using System.Collections.Generic;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Document of agreement. Document build on top of template by providing required configuration properties. Data can be specified on level of clauses or on level of template.
    ///</summary>
    public class Document
    {
        ///$Identity of documents contain globally unique id. Refer to: Structure: /Identity/v1
        public Identity Identity { get; } = new Identity();
        ///$Document is a resource and will be accessible through API. Refer to: Structure: Entity/v1
        public Entity Entity { get; } = new Entity();
        ///$Document will have versions, as it will be evolving. Refer to: Structure: /Version/v1
        public Version Version { get; } = new Version();
        ///List of parties participating in document from list of parties of agreement, Here is refereence by role of the party in agreement.
        public String[] Parties { get; } = new String[0];
        ///$List of components document assembled from.  Refer to: Structure[]: Component/v1
        public Component[] Components { get; } = new Component[0];
        ///Unique identifier of the document.
        public String Id { get; } = string.Empty;
        ///Identifier for the document across versions. The Id of each document version differs for each version. The documentID remains the same for each version.
        public String DocumentId { get; } = string.Empty;
        ///The template used to create the document.
        public String TemplateId { get; } = string.Empty;
        /// name
        public String Name { get; } = string.Empty;
        ///$ Refer to: Enum: 
        public string Type { get; } = String.Empty;
        ///The complete json data set that, with the template, populates the document contents.
        public String Dataset { get; } = string.Empty;
        /// created date
        public DateTime CreatedDate { get; } = DateTime.MinValue;
        /// id of created by person
        public String CreatedById { get; } = string.Empty;
        /// id of the last updated person
        public String LastUpdatedById { get; } = string.Empty;
        ///$Management information for document Refer to: Structure: Element/v1
        public Element Header { get; } = new Element();
        ///Educational material document identifier
        public String DocumentType { get; } = string.Empty;
        ///Educational material reference pointer
        public String Reference { get; } = string.Empty;
        ///Educational material publication date
        public DateTime PublicationDate { get; } = DateTime.MinValue;
        
        public Document(string avatarUrl, string websiteUrl, string name,List<string> photosList, string breed, string coatColor, DateTime? birthDate = null)
        {
            CreatedDate = birthDate?? DateTime.MinValue;
            Name = name;
            Dataset = avatarUrl;
            Reference = breed;
            Parties = photosList.ToArray();
            DocumentId = coatColor;
            PublicationDate = DateTime.MinValue;
        }
    }
}


