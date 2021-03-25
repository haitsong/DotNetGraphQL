using DotNetGraphQL.Common.Enums;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  Event of the clause. Clause fire events when state controlled by clause changed.
    ///</summary>
    public class View
    {
        ///$Identity of the event. Refer to: Structure: /Identity
        public Identity Identity { get; } = new Identity();
        ///Position of event in the list of events 
        public int Ordinal { get; } = 0;
        ///$Type of view. Refer to: Enum: ViewType/v1
        public ViewType Type { get; } = ViewType.DOCUMENT;
        ///$Form factor of view. Refer to: Enum: ViewForm/v1
        public ViewForm Form { get; } = ViewForm.DESKTOP;
        ///$Type of event Refer to: Enum: /Locale/v1
        public Locale Language { get; } = Locale.EN_US;
        ///$View's list of elements. Elements define actual visual components of the view. Refer to: Structure[]: Element/v1
        public Element[] Elements { get; } = new Element[0];
    }
}


