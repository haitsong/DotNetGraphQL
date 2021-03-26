using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   Completion status for stage of execution like: finilization, aproval and so on.
    ///</summary>
    public class CompletionGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.Completion>
    {
        public CompletionGraphType()
        {
            Field<EntityStateEnum>("Status", resolve: x => x.Source.Status, description: @"$Completion Status for some state of execution. Refer to: Enum: EntityState/v1");
            Field(x => x.CompletedAt).Description(@"Date of status acived and satge of activity completed.");
            Field(x => x.CompletedBy).Description(@"Person documented completion of this stage by user name.");
            Field(x => x.CompletedNote).Description(@"Note provided by operator on completion.");
            Field(x => x.CompletedMessage).Description(@"This is link to message, which change status of the issue to specified by this completion.");
        }
    }
}

