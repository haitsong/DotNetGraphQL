using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetGraphQL.Common.Enums
{

    /// <summary>
    /// Type of the link
    /// </summary>
    public enum LinkType
    {
        ///Replaced-by
        REPLACEDBY,  
        ///Replaces
        REPLACES,
        ///Refer
        REFER,
        ///See also
        SEEALSO
    }

}
