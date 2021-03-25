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
        public Identity Parent { get; } = new Identity();
        ///$Type of the entity. Refer to: Enum: EntityType/v1
        public EntityType Type { get; } = EntityType.ACCOUNT;
        ///$State of the entity Refer to: Enum: EntityState/v1
        public EntityState State { get; } = EntityState.ACTIVE;
        ///This entity record is in active use
        public Boolean Active { get; } = false;
        ///List of additional names for the entity.
        public String[] Alias { get; } = new string[0];
        ///$Source system originated the entity. If not specified entity instantiated by core system. Refer to: Enum: BindingType/v1
        public BindingType Source { get; } = BindingType.ERP;
        ///$Reference to entity system bind to. Refer to: Structure[]: Binding/v1
        public Binding[] Bindings { get; } = new Binding[0];
        ///$List of tags for entity association. Refer to: Structure[]: /Identity/v1
        public Identity[] Tags { get; } = new Identity[0];
        ///$Advince properties of the entity. It is name value pairs for additional user defined properties of the entity. Refer to: Structure[]: /Property/v1
        public Property[] Properties { get; } = new Property[0];
        ///$History of the entity instance. Refer to: Structure: History/v1
        public History History { get; } = new History();
    }
}


