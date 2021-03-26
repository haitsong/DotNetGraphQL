using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   Object version. Version presented by 3 values: Major present backward incompatable versions, Minor identify backward compatable version and Revision identified small fixes.
    ///</summary>
    public class VersionGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.Version>
    {
        public VersionGraphType()
        {
            Field(x => x.Major).Description(@"Major version of object. Major version introduced for not backward compatabale changes. New major version of an object can be created only for latest object version.");
            Field(x => x.Minor).Description(@"Minor version of object. Minor version introduce for backward compatable changes. New minor version of an object can be created only for latest object version.");
            Field(x => x.Revision).Description(@"Object revision. Introduced for bag fixes with backward compatability garantee. Revision can be created for any version of the object.");
            Field(x => x.Label).Description(@"Version label. Human friendly label for the version. Label need to be unique for all object versions.");
        }
    }
}

