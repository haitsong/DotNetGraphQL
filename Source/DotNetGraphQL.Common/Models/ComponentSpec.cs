using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Component of template. Component can contain clause or other template.
    ///</summary>
    public class ComponentSpec
    {
        ///Guid
        public String Id { get; set; } = string.Empty;
        ///$Reference to actual template from template catalog. Refer to: Structure: TemplateSpec/v1
        public TemplateSpec Template { get; set; } = new TemplateSpec();
        ///$Reference to actual clause from clause catalog. Refer to: Structure[2]: ClauseSpec/v1
        public ClauseSpec[] Clauses { get; set; } = new ClauseSpec[0];
    }
}


