﻿using GraphQL.Types;
using DotNetGraphQL.Common.Models;

namespace DotNetGraphQL.API
{

    ///<summary>
    ///   Object version. Version presented by 3 values: Major present backward incompatable versions, Minor identify backward compatable version and Revision identified small fixes.
    ///</summary>
    public class VersionInputType : InputObjectGraphType<DotNetGraphQL.Common.Models.Version>
    {
        public VersionInputType()
        {
            Field(x => x.Major).Description(@"Major version of object. Major version introduced for not backward compatabale changes. New major version of an object can be created only for latest object version.");
            Field(x => x.Minor).Description(@"Minor version of object. Minor version introduce for backward compatable changes. New minor version of an object can be created only for latest object version.");
            Field(x => x.Revision).Description(@"Object revision. Introduced for bag fixes with backward compatability garantee. Revision can be created for any version of the object.");
            Field(x => x.Label).Description(@"Version label. Human friendly label for the version. Label need to be unique for all object versions.");
        }
    }

    ///<summary>
    ///   Identity of object in DifHub. Objects can be identify by globaly unique Id and localy unique name.
    ///</summary>
    public class IdentityInputType : InputObjectGraphType<DotNetGraphQL.Common.Models.Identity>
    {
        public IdentityInputType()
        {
            Field(x => x.Id).Description(@"Id of the object. It is global unique identificator, optional for minor objects and required for major objects. When object created Id will be generated by backend service.");
            Field(x => x.Name).Description(@"Name of the object. It is textual object identificator, need to be unique inside folder of the object.");
            Field(x => x.Description).Description(@"Description for the object functionality. It is text with specification of object and way it used in application.");
            // Field<ListGraphType<TranslationInputType>>("Translations", resolve: x => x.Source.Translations, description: @"$Translations for the object name, description to different languages. Object can contains as many translations as required by application. Refer to: Structure[]: /Translation/v1");
        }
    }

    public class ClauseInputType : InputObjectGraphType<Clause>
    {
        public ClauseInputType()
        {
            Name = "ClauseInput";
            Description = "Specification of clause component in catalog. Clause contains specification for schema and rendering.";
            Field<IdentityInputType>("Identity", resolve: x => x.Source.Identity, description: @"$Clause have globally unique id. Refer to: Structure: /Identity/v1");
            Field<VersionInputType>("Version", resolve: x => x.Source.Version, description: @"$Clause will have versions, as it will be evolving. Refer to: Structure: /Version/v1");
            Field<EntityInputType>("Entity", resolve: x => x.Source.Entity, description: @"$Clause is a resource and will be accessible through API.  Refer to: Structure: Entity/v1");
             //   Field<ListGraphType<AttributeInputType>>("Attributes", resolve: x => x.Source.Attributes, description: @"$Clause list of attributes, which defines clause schema. Refer to: Structure[]: Attribute/v1");
            Field(x => x.Parties).Description(@"List of parties recognized by clause. Party presented by name. Name of party used to identify party obligations.");
            //    Field<ListGraphType<EventInputType>>("Events", resolve: x => x.Source.Events, description: @"$List of events supported by clause. Refer to: Structure[]: Event/v1");
        }
    }
}