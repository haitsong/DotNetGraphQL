namespace DotNetGraphQL.Common.Enums
{
    /// <summary>
    /// Enumerator for completion status available in organization.Architect only can add custom status here.
    /// </summary>
    public enum CompletionStatus
    {
        ///Object changes finilized by developer.
        FINILIZED,
        ///Object changes approved by architect.
        APPROVED,
        ///Object changes signed off by compliance.
        SIGNEDOFF
    }


}
