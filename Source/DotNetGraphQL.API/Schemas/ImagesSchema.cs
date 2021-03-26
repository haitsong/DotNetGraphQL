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
            Query = (DocumentsQuery)provider.GetService(typeof(DocumentsQuery));
            Mutation = (DocumentsMutation)provider.GetService(typeof(DocumentsMutation));
        }
    }
}
