using DotNetGraphQL.Common;
using GraphQL.Types;

namespace DotNetGraphQL.API
{
    abstract class ImagesGraphType<T> : ObjectGraphType<T> where T : ImagesModel
    {
        protected ImagesGraphType(string name)
        {
            Name = name;

            Field(x => x.AvatarUrl, false).Description("avatar link url");
            Field<ListGraphType<NonNullGraphType<StringGraphType>>>("imagesList", resolve: x => x.Source.ImagesList, description: "list of pictures");
            Field(x => x.Title, false).Description("title of the image");
            Field(x => x.WebsiteUrl, false).Description("web site");
        }
    }
}
