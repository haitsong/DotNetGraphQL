using DotNetGraphQL.Common.Enums;
using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Completion status for stage of execution like: finilization, aproval and so on.
    ///</summary>
    public class Completion
    {
        ///$Completion Status for some state of execution. Refer to: Enum: EntityState/v1
        public EntityState Status { get; set; } = EntityState.ACTIVE;
        ///Date of status acived and satge of activity completed.
        public DateTime CompletedAt { get; set; } = DateTime.Now;
        ///Person documented completion of this stage by user name.
        public String CompletedBy { get; set; } = string.Empty;
        ///Note provided by operator on completion.
        public String CompletedNote { get; set; } = string.Empty;
        ///This is link to message, which change status of the issue to specified by this completion.
        public String CompletedMessage { get; set; } = string.Empty;
    }
}


