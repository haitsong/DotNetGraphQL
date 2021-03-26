namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Agreement is a container for all agreement documents.
    ///</summary>
    public class Agreement
    {
        ///$Identity of documents contain globally unique id. Refer to: Structure: /Identity/v1
        public Identity? Identity { get; }
        ///$Document is a resource and will be accessible through API. Refer to: Structure: Entity/v1
        public Entity Entity { get; set; } = new Entity();
        ///$Parties participating in agreement. Refer to: Structure[]: AgreementParty/v1
        public AgreementParty[] Parties { get; set; } = new AgreementParty[0];
    }
}


