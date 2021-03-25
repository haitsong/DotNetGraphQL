namespace DotNetGraphQL.Common.Enums
{
    /// <summary>
    /// Enumerator of supported roles for users of the object. Role defines permisions user will have to object properties.
    /// </summary>
    public enum Role
    {

        ///Team Architect. Architect have full access to objects in his area of responsibility. Architect can approve changes and access to objects under his control., 0, ["Read","Write","Approve"]
        ARCHITECT,
        ///Team Architect. Architect have full access to objects in his area of responsibility. Architect can approve changes and access to objects under his control., 1, ["Read","Write"]
        DEVELOPER,
        ///AAnalyst can review objects he have access to. Analyst can create issue or comment on exiting issues., 2, 
        ANALYST,
        ///Analyst can review objects he have access to. Analyst can create issue or comment on exiting issues., 3, ["Read","Write","Approve"] 

        PRODUCT,
        ///Team Business Manager. Business manager have access to object similar to developer, as he can contribute to design and metadata generation.., 4, ["Read","Write"]

        BUSINESS,
        ///Team Operation support. Operator can review objects and create/modify issues. Operator have permissions similar to Analyst., 5, ["Read"] 

        OPERATIONS
    }


}
