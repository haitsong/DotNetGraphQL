using DotNetGraphQL.Common.Enums;
using System;

namespace DotNetGraphQL.Common.Models
{
    ///<summary>
    ///  View Element. Element represent visual component of view.
    ///</summary>
    public class Element
    {
        ///$Identity of view element. Refer to: Structure: /Identity/v1
        public Identity Identity { get; } = new Identity();
        ///Order define position for element in view. Elements can have different order from sequence of specification. If order define as 0 it same as sequence number of specification.
        public uint Order { get; } = 0;
        ///Reference to parent element. Parent define frame this element included in.
        public Identity Parent { get; } = new Identity();
        ///$Visability property defines if it visual or hidden. Refer to: Enum: EventType/v1
        public EventType Visibility { get; } = EventType.CUSTOM;
        ///$Frame of element. Frame define rectangular view for element visual components. Refer to: Structure: Clause/v1
        public Clause Frame { get; } = new Clause();
        ///$Style of element. Style define attributes of element visual components. Refer to: Structure: Clause/v1
        public Clause Style { get; } = new Clause();
        ///$Image of element visual component. Refer to: Structure: Attribute/v1
        public Attribute Image { get; } = new Attribute();
        ///Text of element visual component.
        public String Text { get; } = string.Empty;
        ///$Alignment of text in element content frame. Refer to: Enum: EventType/v1
        public EventType Align { get; } = EventType.CUSTOM;
        ///$Control of element. Control define configuration for visual compoments. Refer to: Structure: Clause/v1
        public Clause Control { get; } = new Clause();
    }
}


