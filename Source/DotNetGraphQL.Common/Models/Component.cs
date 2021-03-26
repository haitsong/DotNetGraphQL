using DotNetGraphQL.Common.Enums;
using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Component of template. Component can contain clause or other template.
    ///</summary>
    public class Component
    {
        ///Identity of component must be unique inside template.
        public Guid Id { get; set; } = Guid.Empty;
        ///$Management information for component Refer to: Structure: Element/v1
        public Element Header { get; set; } = new Element();
        ///$Type of component defines it use clause or other template. Refer to: Enum: ComponentType/v1
        public ComponentType Type { get; set; } = ComponentType.CLAUSE;
        ///$List of parties used in component. Refer to: Structure[]: ComponentParty/v1
        public ComponentParty[] Parties { get; set; } = new ComponentParty[0];
        ///$Reference to actual template or clause from catalog. Refer to: Structure: ComponentSpec/v1
        public ComponentSpec Specification { get; set; } = new ComponentSpec();
        ///Specification of values for clause or template attributes. Reference  to attributes of current template attributes can be used to configure clause or template.
        public String Dataset { get; set; } = string.Empty;
    }
}


