using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Component of template. Component can contain clause or other template.
    ///</summary>
    public class Action
    {
        ///Identity of action must be unique inside template.
        public Guid Id { get; } = Guid.Empty;
        ///$Management information for action Refer to: Structure: Element/v1
        public Element Header { get; } = new Element();
        ///Component id in the template action defined for.
        public Guid Component { get; } = Guid.Empty;
        ///Event id in the component action defined for.
        public Guid Event { get; } = Guid.Empty;
        ///Obligation action to support.
        public Obligation Obligation { get; } = new Obligation();
        ///Workflow to execute for obligation support.
        public Identity Workflow { get; } = new Identity();
    }
}


