using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Component of template. Component can contain clause or other template.
    ///</summary>
    public class TemplateSpec
    {
        ///Guid
        public String Id { get; } = string.Empty;
        ///Reference to actual template or clause from catalog.
        public Template Reference { get; } = new Template();
        ///List of components template build from.
        public Component[] Components { get; } = new Component[0];
    }
}


