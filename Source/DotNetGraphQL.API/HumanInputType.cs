using GraphQL.Types;
using DotNetGraphQL.Common.Models;

namespace DotNetGraphQL.API
{
    public class HumanInputType : InputObjectGraphType<Human>
    {
        public HumanInputType()
        {
            Name = "HumanInput";
            Description = "Human input type to define creating human";
            Field(x => x.Name).Description("name of the human");
            Field(x => x.HomePlanet, nullable: true).Description("home planet of human");
        }
    }

    public class PersonInputType : InputObjectGraphType<Person>
    {
        public PersonInputType()
        {
            Name = "PersonInput";
            Description = "Person input type";
            Field(x => x.FirstName, nullable: true).Description("first name");
            Field(x => x.LastName).Description("last name");
        }
    }

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

}
