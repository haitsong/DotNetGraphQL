using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   Updatable entity. Entity can be accessed by RESTful API and referenced.
    ///</summary>
    public class EntityGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.Entity>
    {
        public EntityGraphType()
        {
            Field<IdentityGraphType>("Parent", resolve: x => x.Source.Parent, description: @"$Reference to id of folder for current entity. It include URI of parent entity in name. Refer to: Structure: /Identity");
            Field<EntityTypeEnum>("Type", resolve: x => x.Source.Type, description: @"$Type of the entity. Refer to: Enum: EntityType/v1");
            Field<EntityStateEnum>("State", resolve: x => x.Source.State, description: @"$State of the entity Refer to: Enum: EntityState/v1");
            Field(x => x.Active).Description(@"This entity record is in active use");
            Field(x => x.Alias).Description(@"List of additional names for the entity.");
            Field<BindingTypeEnum>("Source", resolve: x => x.Source.Source, description: @"$Source system originated the entity. If not specified entity instantiated by core system. Refer to: Enum: BindingType/v1");
            Field<ListGraphType<BindingGraphType>>("Bindings", resolve: x => x.Source.Bindings, description: @"$Reference to entity system bind to. Refer to: Structure[]: Binding/v1");
            Field<ListGraphType<IdentityGraphType>>("Tags", resolve: x => x.Source.Tags, description: @"$List of tags for entity association. Refer to: Structure[]: /Identity/v1");
            Field<ListGraphType<PropertyGraphType>>("Properties", resolve: x => x.Source.Properties, description: @"$Advince properties of the entity. It is name value pairs for additional user defined properties of the entity. Refer to: Structure[]: /Property/v1");
            Field<HistoryGraphType>("History", resolve: x => x.Source.History, description: @"$History of the entity instance. Refer to: Structure: History/v1");
        }
    }
}

