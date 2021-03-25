using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Integration of template with enterprise internal and external systems. Template can have multiple integrations designed for different set of systems. When document created, integration relevant for party will be used.
    ///</summary>
    public class Integration
    {
        ///$Identity of integration contains globally unique id. Refer to: Structure: /Identity/v1
        public Identity Identity { get; } = new Identity();
        ///$Integration will have versions, as it will be evolving. Refer to: Structure: /Version/v1
        public Version Version { get; } = new Version();
        ///$Integration is a resource and will be accessible through API. Parent for Integration is a Template.   Refer to: Structure: Entity/v1
        public Entity Entity { get; } = new Entity();
        ///Party of template, integration is applicable for.
        public String Party { get; } = string.Empty;
        ///$List of attributes template required to specify for document. Refer to: Structure[]: Attribute/v1
        public Attribute[] Attributes { get; } = new Attribute[0];
        ///$List of actions implemented in template. Refer to: Structure[]: Action/v1
        public Action[] Actions { get; } = new Action[0];
    }
}


