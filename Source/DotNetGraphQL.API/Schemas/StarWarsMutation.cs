using GraphQL;
using GraphQL.Types;
using DotNetGraphQL.API;
using DotNetGraphQL.Common.Models;

namespace DotNetGraphQL.API.Schemas
{

    /// <example>
    /// This is an example JSON request for a mutation
    /// {
    ///   "query": "mutation ($human:HumanInput!){ createHuman(human: $human) { id name } }",
    ///   "variables": {
    ///     "human": {
    ///       "name": "Boba Fett"
    ///     }
    ///   }
    /// }
    /// </example>
    public class StarWarsMutation : ObjectGraphType
    {
        public StarWarsMutation(StarWarsData data)
        {
            Name = "Mutation";

            Field<HumanType>(
                "createHuman",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<HumanInputType>> { Name = "human" }
                ),
                resolve: context =>
                {
                    var human = context.GetArgument<Human>("human");
                    return data.AddHuman(human);
                });

            Field<PersonGraphType>(
                "createPerson",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<PersonInputType>> { Name ="person" },
                    new QueryArgument<NonNullGraphType<AddressInputType>> { Name = "address" }
                ),
                resolve: context =>
                {
                    var person = context.GetArgument<Person>("person");
                    var address = context.GetArgument<Address>("address");
                    return data.AddPerson(person, address);
                });
        }
    }
}

