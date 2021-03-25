using DotNetGraphQL.Common.Enums;
using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Link to a resource that associated with current resource.
    ///</summary>
    public class Link
    {
        ///$Element data inherited from element structure Refer to: Structure: Element/v1
        public String ElementId { get; } = string.Empty;
        ///$Extensions that cannot be ignored Refer to: Structure[]: Extension/v1
        ///Extension[] ModifierExtension { get; } = new Extension[0];
        /// The resource to which this resource is associated.
        public Identity Target { get; } = new Identity();
        ///$Identity assurance level for related objects Refer to: Enum: IdentityAssuranceLevel/v1
        ///IdentityAssuranceLevel Assurance { get; };
        ///$Type of the link. Refer to: Enum: LinkType/v1
        public LinkType Type { get; } = LinkType.REFER;
    }
}


