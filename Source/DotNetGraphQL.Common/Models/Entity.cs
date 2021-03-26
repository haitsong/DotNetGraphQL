using DotNetGraphQL.Common.Enums;
using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Updatable entity. Entity can be accessed by RESTful API and referenced.
    ///</summary>
    public class Entity
    {
        ///$Reference to id of folder for current entity. It include URI of parent entity in name. Refer to: Structure: /Identity
        public Identity Parent { get; set; } = new Identity();
        ///$Type of the entity. Refer to: Enum: EntityType/v1
        public EntityType Type { get; set; } = EntityType.ACCOUNT;
        ///$State of the entity Refer to: Enum: EntityState/v1
        public EntityState State { get; set; } = EntityState.ACTIVE;
        ///This entity record is in active use
        public Boolean Active { get; set; } = false;
        ///List of additional names for the entity.
        public String[] Alias { get; set; } = new string[0];
        ///$Source system originated the entity. If not specified entity instantiated by core system. Refer to: Enum: BindingType/v1
        public BindingType Source { get; set; } = BindingType.ERP;
        ///$Reference to entity system bind to. Refer to: Structure[]: Binding/v1
        public Binding[] Bindings { get; set; } = new Binding[0];
        ///$List of tags for entity association. Refer to: Structure[]: /Identity/v1
        public Identity[] Tags { get; set; } = new Identity[0];
        ///$Advince properties of the entity. It is name value pairs for additional user defined properties of the entity. Refer to: Structure[]: /Property/v1
        public Property[] Properties { get; set; } = new Property[0];
        ///$History of the entity instance. Refer to: Structure: History/v1
        public History History { get; set; } = new History();
    }
}


