using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   Structure for object history. Object history provides information when object was updated and in what completion state it is now.
    ///</summary>
    public class HistoryGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.History>
    {
        public HistoryGraphType()
        {
            Field(x => x.CreatedAt).Description(@"Date of object creation.");
            Field(x => x.CreatedBy).Description(@"User created object.");
            Field(x => x.UpdatedAt).Description(@"Date of object last update. This is important value as it is flag for optimistic commit to detect overriding changes. ");
            Field(x => x.UpdatedBy).Description(@"User last updated object.");
            Field(x => x.UpdatedNote).Description(@"Mote about goal of object update.");
            Field(x => x.UpdatedMessage).Description(@"Message in issue associated with changes in object.");
            Field(x => x.ReviewedAt).Description(@"Date object last update was reviewed by owner. This is indicates user see and aknowalage change.");
            Field(x => x.ReviewedBy).Description(@"User who reviewed and acknowledge the last update changes.");
            Field(x => x.RetiredAt).Description(@"Date object was retired.");
            Field(x => x.RetiredBy).Description(@"User retired object.");
            Field<ListGraphType<CompletionGraphType>>("Completions", resolve: x => x.Source.Completions, description: @"$Array of completion statuses reached by this object. Refer to: Structure[]: Completion/v1");
        }
    }
}

