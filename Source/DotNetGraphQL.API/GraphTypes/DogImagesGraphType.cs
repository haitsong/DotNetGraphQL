using DotNetGraphQL.Common;
using GraphQL.Types;

namespace DotNetGraphQL.API
{
    class DogImagesGraphType : ImagesGraphType<DogImagesModel>
    {
        public DogImagesGraphType() : base("Dog")
        {
            Description = "dog class representing a dog";
            Field(x => x.Breed, false).Description("breed of dog");
            Field<DateTimeGraphType>("birthDate", resolve: x => x.Source.BirthDate,description: "birth date of dog");
            Field(x => x.CoatColor, false).Description("coat color");
        }
    }
}
