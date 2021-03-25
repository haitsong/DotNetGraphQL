namespace DotNetGraphQL.Common.Enums
{
    /// <summary>
    ///     Enumerator of the issue resolutions.Issue resolution defines how issue was resolved.
    /// </summary>
    public enum IssueResolution
    {
        ///Issue was fixed by developer.
        FIXED,
        ///Issue was resolved as aproval for request.
        APROVED,
        ///Issue was resolve as rejection of request or sajetion.
        DECLINED,
        ///Issue wasn't reproduced in current state of the system.
        NOTREPRODUCED,
        ///Feature was designed this way and it is not an Issue.
        BYDESIGN,
        ///Issue is duplicate of some other issue. Issue it duplicate to will be specified in link.
        DUPLICATE,
        ///Issue was postponed to next development cycle.
        POSTPONED
    }


}
