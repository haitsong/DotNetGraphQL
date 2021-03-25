using DotNetGraphQL.Common;
using GraphQL.Types;

namespace DotNetGraphQL.API
{
    class DogImagesGraphType : ImagesGraphType<DogImagesModel>
    {
        public DogImagesGraphType() : base("Dog")
        {
            Description = "dog class representing a dog";
            Field(x => x.Breed, false);
            Field<DateTimeGraphType>("birthDate", resolve: x => x.Source.BirthDate);
            Field(x => x.CoatColor, false);
        }
    }
}
