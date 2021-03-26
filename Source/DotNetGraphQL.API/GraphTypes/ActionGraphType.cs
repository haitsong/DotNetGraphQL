using GraphQL.Types;

namespace DotNetGraphQL.API
{
    ///<summary>
    ///   Component of template. Component can contain clause or other template.
    ///</summary>
    public class ActionGraphType : ObjectGraphType<DotNetGraphQL.Common.Models.Action>
    {
        public ActionGraphType()
        {
            Field(x => x.Id).Description(@"Identity of action must be unique inside template.");
            Field<ElementGraphType>("Header", resolve: x => x.Source.Header, description: @"$Management information for action Refer to: Structure: Element/v1");
            Field(x => x.Component).Description(@"Component id in the template action defined for.");
            Field(x => x.Event).Description(@"Event id in the component action defined for.");
            Field(x => x.Obligation).Description(@"Obligation action to support.");
            Field(x => x.Workflow).Description(@"Workflow to execute for obligation support.");
        }
    }
}

