namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Obligation defined by clause. Obligation will be fired when event associated with it fired up.
    ///</summary>
    public class Obligation
    {
        ///$Obligation have globally unique id. Refer to: Structure: /Identity/v1
        public Identity Identity { get; set; } = new Identity();
        ///$Clause will have versions, as it will be evolving. Refer to: Structure: /Version/v1
        public Version Version { get; set; } = new Version();
        ///$Schema is a resource and will be accessible through API.  Refer to: Structure: Entity/v1
        public Entity Entity { get; set; } = new Entity();
        ///$Attributes of the schema Refer to: Structure[]: Attribute/v1
        public Attribute[] Attributes { get; set; } = new Attribute[0];
    }
}


