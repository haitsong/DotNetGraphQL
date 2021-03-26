using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   Translation for object identity to specific language. Translation can contains information for value of object specific to language it represents.
    ///</summary>
    public class TranslationGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.Translation>
    {
        public TranslationGraphType()
        {
            Field<LocaleEnum>("Locale", resolve: x => x.Source.Locale, description: @"$Locale for language translation defined for. Refer to: Enum: /Locale/v1");
            Field(x => x.Name).Description(@"Translation for object name.");
            Field(x => x.Description).Description(@"Translation for object description.");
            Field(x => x.Value).Description(@"Value specific to translation locale for objects with value.");
        }
    }
}

