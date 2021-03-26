using GraphQL.Types;

namespace DotNetGraphQL.API
{

    ///<summary>
    ///   Document of agreement. Document build on top of template by providing required configuration properties. Data can be specified on level of clauses or on level of template.
    ///</summary>
    public class DocumentGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.Document>
    {
        public DocumentGraphType()
        {
            Field<IdentityGraphType>("Identity", resolve: x => x.Source.Identity, description: @"$Identity of documents contain globally unique id. Refer to: Structure: /Identity/v1");
            Field<EntityGraphType>("Entity", resolve: x => x.Source.Entity, description: @"$Document is a resource and will be accessible through API. Refer to: Structure: Entity/v1");
            Field<VersionGraphType>("Version", resolve: x => x.Source.Version, description: @"$Document will have versions, as it will be evolving. Refer to: Structure: /Version/v1");
            Field(x => x.Parties).Description(@"List of parties participating in document from list of parties of agreement, Here is refereence by role of the party in agreement.");
            Field<ListGraphType<ComponentGraphType>>("Components", resolve: x => x.Source.Components, description: @"$List of components document assembled from.  Refer to: Structure[]: Component/v1");
            Field(x => x.Id).Description(@"Document id in list of documents");
            Field<ElementGraphType>("Header", resolve: x => x.Source.Header, description: @"$Management information for document Refer to: Structure: Element/v1");
            Field(x => x.DocumentType).Description(@"Educational material document identifier");
            Field(x => x.Reference).Description(@"Educational material reference pointer");
            Field(x => x.PublicationDate).Description(@"Educational material publication date");

            Field(x => x.DocumentId).Description(@"Identifier for the document across versions. The Id of each document version differs for each version. The documentID remains the same for each version.");
            Field(x => x.TemplateId).Description(@"The template used to create the document.");
            Field(x => x.Name).Description(@"name of the document");
            Field(x => x.Dataset).Description(@"The complete json data set that, with the template, populates the document contents.");
            Field(x => x.CreatedDate).Description(@"created at date");
            Field(x => x.CreatedById).Description(@"created by person id");
            Field(x => x.LastUpdatedById).Description(@"last update by person id");
        }
    }
}

