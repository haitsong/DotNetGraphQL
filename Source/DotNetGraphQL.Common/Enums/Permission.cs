namespace DotNetGraphQL.Common.Enums
{
    /// <summary>
    ///  Define what access users have to the field data: Read, Write or Read and Write.Permissions is a bit-mask and can apply simultaneously.
    /// </summary>
    public enum Permission
    {
        ///Users allowed read content.
        READ,
        ///User allowed write (change) content.
        WRITE,
        ///User allowed execute available commands or scripts.
        EXECUTE
    }


}
