using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Structure for object history. Object history provides information when object was updated and in what completion state it is now.
    ///</summary>
    public class History
    {
        ///Date of object creation.
        public DateTime Created { get; } = DateTime.Now;
        ///User created object.
        public String CreatedBy { get; } = string.Empty;
        ///Date of object last update.
        public DateTime Updated { get; } = DateTime.Now;
        ///User last updated object.
        public String UpdatedBy { get; } = string.Empty;
        ///Mote about goal of object update.
        public String UpdateNote { get; } = string.Empty;
        ///Message in issue associated with changes in object.
        public String UpdateMessage { get; } = string.Empty;
        ///Date object was mirrored into GitHub.
        public DateTime Mirrored { get; } = DateTime.Now;
        ///Date object was retired.
        public DateTime Retired { get; } = DateTime.Now;
        ///User retired object.
        public String RetiredBy { get; } = string.Empty;
        ///$Array of completion statuses reached by this object. Refer to: Structure[]: Completion/v1
        public Completion[] Completions { get; } = new Completion[0];
        ///Date of object creation.
        public DateTime CreatedAt { get; } = DateTime.Now;
        ///Date of object last update. This is important value as it is flag for optimistic commit to detect overriding changes. 
        public DateTime UpdatedAt { get; } = DateTime.Now;
        ///Mote about goal of object update.
        public String UpdatedNote { get; } = string.Empty;
        ///Message in issue associated with changes in object.
        public String UpdatedMessage { get; } = string.Empty;
        ///Date object last update was reviewed by owner. This is indicates user see and aknowalage change.
        public DateTime ReviewedAt { get; } = DateTime.Now;
        ///User who reviewed and acknowledge the last update changes.
        public String ReviewedBy { get; } = string.Empty;
        ///Date object was retired.
        public DateTime RetiredAt { get; } = DateTime.MinValue;
    }
}


