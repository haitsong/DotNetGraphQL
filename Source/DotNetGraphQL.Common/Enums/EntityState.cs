namespace DotNetGraphQL.Common.Enums
{
    ///Enumerator of the entity state.///
    public enum EntityState
    {
        ///Entity in draft state and not ready yet for approval.
        DRAFT,
        ///Entity pending approval and can't be used.
        PENDING,
        ///Entity in active state and can be used.
        ACTIVE,
        ///Entity retired and cannot be executed any more.
        RETIRED,
        ///Entity in have error and can't be used.
        ERROR
    }


}
