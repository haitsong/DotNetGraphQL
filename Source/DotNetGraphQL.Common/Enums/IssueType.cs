namespace DotNetGraphQL.Common.Enums
{
    /// <summary>
    ///Enumerator of the issue types.#
    /// </summary>
    public enum IssueType
    {
        ///Initiative for busness solution., 0, 1.0, 
        INITIATIVE,
        ///Feature for system or application., 1, 1.0, 
        FEATURE,
        ///Discussion about any topic., 2, 1.0, 
        DISCUSSION,
        ///Work Item for changes in design or code.  Default type for issue., 3, 1.0, 
        WORK_ITEM,
        ///Request for support from team or organization., 4, 1.0, 
        SUPPORT_REQUEST,
        ///Suggestion for object design., 5, 1.0, 
        DESIGN_SUGGESTION,
        ///Problem in object design., 6, 1.0, 
        DESIGN_PROBLEM,
        ///Problem in implementation., 7, 1.0, 
        CODE_DEFECT
    }


}
