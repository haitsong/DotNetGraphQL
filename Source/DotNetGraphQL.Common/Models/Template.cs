using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Template of agreement. Template specified prototype for agreements. Agreement documents use template to configure actual agreement. Template contains two main parts: attributes and components. Attributes provide specification of configuration parameters for template. Components defines smart clauses document will be assembled from.
    ///</summary>
    public class Template
    {
        ///$Identity of template contains globally unique id. Refer to: Structure: /Identity/v1
        public Identity Identity { get; set; } = new Identity();
        ///$Template will have versions, as it will be evolving. Refer to: Structure: /Version/v1
        public Version Version { get; set; } = new Version();
        ///$Template is a resource and will be accessible through API.  Refer to: Structure: Entity/v1
        public Entity Entity { get; set; } = new Entity();
        ///List of parties recognized by template. Party presented by name. Name of party used to identify party connection to templates clauses..
        public String[] Parties { get; set; } = new string[0];
        ///$List of attributes template required to specify for document. Refer to: Structure[]: Attribute/v1
        public Attribute[] Attributes { get; set; } = new Attribute[0];
        ///$List of components template assembled from.  Refer to: Structure[]: Component/v1
        public Component[] Components { get; set; } = new Component[0];
        ///Unique identifier for the template
        public String Id { get; set; } = string.Empty;
        ///
        public String Name { get; set; } = string.Empty;
    }
}


