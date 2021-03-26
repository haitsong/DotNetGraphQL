using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Structure for object history. Object history provides information when object was updated and in what completion state it is now.
    ///</summary>
    public class History
    {
        ///Date of object creation.
        public DateTime Created { get; set; } = DateTime.Now;
        ///User created object.
        public String CreatedBy { get; set; } = string.Empty;
        ///Date of object last update.
        public DateTime Updated { get; set; } = DateTime.Now;
        ///User last updated object.
        public String UpdatedBy { get; set; } = string.Empty;
        ///Mote about goal of object update.
        public String UpdateNote { get; set; } = string.Empty;
        ///Message in issue associated with changes in object.
        public String UpdateMessage { get; set; } = string.Empty;
        ///Date object was mirrored into GitHub.
        public DateTime Mirrored { get; set; } = DateTime.Now;
        ///Date object was retired.
        public DateTime Retired { get; set; } = DateTime.Now;
        ///User retired object.
        public String RetiredBy { get; set; } = string.Empty;
        ///$Array of completion statuses reached by this object. Refer to: Structure[]: Completion/v1
        public Completion[] Completions { get; set; } = new Completion[0];
        ///Date of object creation.
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        ///Date of object last update. This is important value as it is flag for optimistic commit to detect overriding changes. 
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        ///Mote about goal of object update.
        public String UpdatedNote { get; set; } = string.Empty;
        ///Message in issue associated with changes in object.
        public String UpdatedMessage { get; set; } = string.Empty;
        ///Date object last update was reviewed by owner. This is indicates user see and aknowalage change.
        public DateTime ReviewedAt { get; set; } = DateTime.Now;
        ///User who reviewed and acknowledge the last update changes.
        public String ReviewedBy { get; set; } = string.Empty;
        ///Date object was retired.
        public DateTime RetiredAt { get; set; } = DateTime.MinValue;
    }
}


