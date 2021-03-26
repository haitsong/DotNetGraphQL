using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Party of component of template. Party map template and document party to parties of clause or template in component..
    ///</summary>
    public class ComponentParty
    {
        ///Name of clause or template party inside component. This is party name specified in actual clause or template reference by component. 
        public String Id { get; set; } = string.Empty;
        ///$Management information for component party. Refer to: Structure: Element/v1
        public Element Header { get; set; } = new Element();
        ///Reference to actual party of template or document by name of the party/.
        public String Party { get; set; } = string.Empty;
        ///Specification of values for the party as it presented in component on time of document creation..
        public String Dataset { get; set; } = string.Empty;
    }
}


