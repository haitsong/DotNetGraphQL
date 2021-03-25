using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetGraphQL.Common.Enums
{
    /// <summary>
    /// Component type define what entity use as component. #
    /// </summary>
    public enum ComponentType
    {
        ///Clause used as component of template or document.
        CLAUSE,    
        ///Template used as component for document or other template.
        TEMPLATE
    }
}
