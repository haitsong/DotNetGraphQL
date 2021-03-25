using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Specification of clause component in catalog. Clause contains specification for schema and rendering.
    ///</summary>
    public class Clause
    {
        ///$Clause have globally unique id. Refer to: Structure: /Identity/v1
        public Identity Identity { get; } = new Identity();
        ///$Clause will have versions, as it will be evolving. Refer to: Structure: /Version/v1
        public Version Version { get; } = new Version();
        ///$Clause is a resource and will be accessible through API.  Refer to: Structure: Entity/v1
        public Entity Entity { get; } = new Entity();
        ///List of parties recognized by clause. Party presented by name. Name of party used to identify party obligations.
        public String[] Parties { get; } = new string[0];
        ///$Clause list of attributes, which defines clause schema. Refer to: Structure[]: Attribute/v1
        public Attribute[] Attributes { get; } = new Attribute[0];
        ///$List of events supported by clause. Refer to: Structure[]: Event/v1
        public Event[] Events { get; } = new Event[0];
    }
}


