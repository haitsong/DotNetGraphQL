﻿using GraphQL.Types;
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
            Field<ClauseSchemaGraphType>("Reference", resolve: x => x.Source.Reference, description: "reference");
            Field(x => x.Ordinal, nullable: true).Description("ordinal");
        }
    }

    public class EntityInputType : InputObjectGraphType<Entity>
    {
        public EntityInputType()
        {
            Name = "EntityInput";
            Description = "Entity input type to define Entity";
            Field(x => x.Active, nullable: true).Description("Active");
            Field(x => x.Alias, nullable: true).Description("alias");
            Field(x => x.Source, nullable: true).Description("Source");
            Field(x => x.State, nullable: true).Description("State");
        }
    }

    public class ClauseSchemaInputType : InputObjectGraphType<ClauseSchema>
    {
        public ClauseSchemaInputType()
        {
            Name = "ClauseSchemaInput";
            Description = "ClauseSchema input type to define creating address";
            Field<EntityGraphType>("Entity", resolve: x => x.Source.Entity, description: "Entity");
        }
    }

}
