using GraphQL.Types;
using System;
using DotNetGraphQL.API.Schemas;

namespace DotNetGraphQL.API
{
    public class ImagesSchema : Schema
    {
        private static StarWarsData data = new StarWarsData();
        public ImagesSchema(IServiceProvider provider)
            : base(provider)
        {
            Query = (ImagesQuery)provider.GetService(typeof(ImagesQuery));
            Mutation = (StarWarsMutation)provider.GetService(typeof(StarWarsMutation));
        }
    }
}
