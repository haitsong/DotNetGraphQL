using System;

namespace DotNetGraphQL.Common.Models
{
    /// <summary>
    /// Object version.Version presented by 3 values: Major present backward incompatable versions, Minor identify backward compatable version and Revision identified small fixes.
    /// </summary>
    public class Version
    {
        /// <summary>
        /// Major version of object. Major version introduced for not backward compatabale changes.New major version of an object can be created only for latest object version.
        /// </summary>
        public ushort Major { get; }
        /// <summary>
        /// Minor version of object. Minor version introduce for backward compatable changes.New minor version of an object can be created only for latest object version.
        /// </summary>
        public ushort Minor { get; }
        /// <summary>
        ///  Object revision.Introduced for bag fixes with backward compatability garantee. Revision can be created for any version of the object.
        /// </summary>
        public uint Revision { get; }
        /// <summary>
        /// Version label.Human friendly label for the version. Label need to be unique for all object versions.
        /// </summary>
        public String Label { get; } = string.Empty;
    }
}
