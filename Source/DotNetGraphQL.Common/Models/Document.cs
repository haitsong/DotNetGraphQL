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
        public Identity Identity { get; set; } = new Identity();
        ///$Document is a resource and will be accessible through API. Refer to: Structure: Entity/v1
        public Entity Entity { get; set; } = new Entity();
        ///$Document will have versions, as it will be evolving. Refer to: Structure: /Version/v1
        public Version Version { get; set; } = new Version();
        ///List of parties participating in document from list of parties of agreement, Here is refereence by role of the party in agreement.
        public String[] Parties { get; set; } = new String[0];
        ///$List of components document assembled from.  Refer to: Structure[]: Component/v1
        public Component[] Components { get; set; } = new Component[0];
        ///Unique identifier of the document.
        public String Id { get; set; } = string.Empty;
        ///Identifier for the document across versions. The Id of each document version differs for each version. The documentID remains the same for each version.
        public String DocumentId { get; set; } = string.Empty;
        ///The template used to create the document.
        public String TemplateId { get; set; } = string.Empty;
        /// name
        public String Name { get; set; } = string.Empty;
        ///$ Refer to: Enum: 
        public string Type { get; set; } = String.Empty;
        ///The complete json data set that, with the template, populates the document contents.
        public String Dataset { get; set; } = string.Empty;
        /// created date
        public DateTime CreatedDate { get; set; } = DateTime.MinValue;
        /// id of created by person
        public String CreatedById { get; set; } = string.Empty;
        /// id of the last updated person
        public String LastUpdatedById { get; set; } = string.Empty;
        ///$Management information for document Refer to: Structure: Element/v1
        public Element Header { get; set; } = new Element();
        ///Educational material document identifier
        public String DocumentType { get; set; } = string.Empty;
        ///Educational material reference pointer
        public String Reference { get; set; } = string.Empty;
        ///Educational material publication date
        public DateTime PublicationDate { get; set; } = DateTime.MinValue;
        
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


