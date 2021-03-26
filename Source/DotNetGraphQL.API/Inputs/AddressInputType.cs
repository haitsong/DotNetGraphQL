using GraphQL.Types;
using DotNetGraphQL.Common.Models;

namespace DotNetGraphQL.API
{
    public class AddressInputType : InputObjectGraphType<Address>
    {
        public AddressInputType()
        {
            Name = "AddressInput";
            Description = "Address input type to define creating address";
            Field(x => x.StreetAddress, nullable: true).Description("street address");
            Field(x => x.ZipOrPostalCode, nullable: true).Description("zip code");
            Field(x => x.State, nullable: true).Description("state");
            Field(x => x.City).Description("city");
        }
    }

    public class  AttributeInputType : InputObjectGraphType<Attribute>
    {
        public AttributeInputType()
        {
            Name = "AttributeInput";
            Description = "Attribute input type to define creating address";
            Field(x => x.Format, nullable: true).Description("attribute format");
            Field<ClauseSchemaInputType>("Reference", resolve: x => x.Source.Reference, description: "reference");
            Field(x => x.Ordinal, nullable: true).Description("ordinal");
        }
    }

    public class EntityInputType : InputObjectGraphType<Entity>
    {
        public EntityInputType()
        {
            Name = "EntityInput";
            Description = "Entity input type to define Entity";
            Field(x => x.Active).Description("Active");
            Field(x => x.Alias).Description("alias: array of string");
            Field<BindingTypeEnum>("Source", resolve: x => x.Source.Source, description: "Source");
            Field<EntityStateEnum>("State" , resolve: x => x.Source.State, description: "State");
        }
    }

    public class ClauseSchemaInputType : InputObjectGraphType<ClauseSchema>
    {
        public ClauseSchemaInputType()
        {
            Name = "ClauseSchemaInput";
            Description = "ClauseSchema input type to define creating address";
            Field<EntityInputType>("Entity", resolve: x => x.Source.Entity, description: "Entity");
        }
    }

}
