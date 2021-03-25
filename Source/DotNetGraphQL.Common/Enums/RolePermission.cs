namespace DotNetGraphQL.Common.Enums
{
    /// <summary>
    ///     Define what access role can have to objects: Read, Write or Approve.Permissions is a bit-mask and can apply simultaneously.
    /// </summary>
    public enum RolePermission
    {
        ///Users allowed read object content.
        READ,
        ///User allowed write (update) object content.
        WRITE,
        ///User allowed approve object changes.
        APPROVE
    }


}
