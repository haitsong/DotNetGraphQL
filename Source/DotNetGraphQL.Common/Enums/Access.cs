namespace DotNetGraphQL.Common.Enums
{
    /// <summary>
    /// Access to publication or other object. Access defines expose of object to users of other organizations.
    /// </summary>
    public enum Access
    {
        ///Access only to architects, developers and analysts of current object.
        PRIVATE,
        /// Access only architects, developers and analysts inside parent folder (organization, system or application).
        INTERNAL,
        ///Access to any user of current organization.
        EXTERNAL,
        ///Access for users of other organizations.
        PUBLIC
    }


}
