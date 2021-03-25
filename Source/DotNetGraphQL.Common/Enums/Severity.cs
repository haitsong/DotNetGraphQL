using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetGraphQL.Common.Enums
{

    /// <summary>
    /// Severity of the error.Enumerate classification of the error severity in execution path.  
    /// </summary>
    public enum Severity
    {

        ///A severe error that causes your system to crash, resulting in the loss or corruption of unsaved data.
        FATAL,
        ///A severe error that might cause the loss or corruption of unsaved data. Immediate action must be taken to prevent losing data.
        ERROR,
        ///Action must be taken at some stage to prevent a severe error from occurring in the future.
        WARNING,
        ///An informative message, usually describing server activity. No action is necessary.
        INFO
    }
}
