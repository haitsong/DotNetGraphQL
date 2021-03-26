using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Component of template. Component can contain clause or other template.
    ///</summary>
    public class TemplateSpec
    {
        ///Guid
        public String Id { get; set; } = string.Empty;
        ///Reference to actual template or clause from catalog.
        public Template Reference { get; set; } = new Template();
        ///List of components template build from.
        public Component[] Components { get; set; } = new Component[0];
    }
}


