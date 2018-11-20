using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workflow.Infrastructure.Enums
{
    public enum StatusType: byte
    {
        [Description("Pending")]
        Pending = 1,

        [Description("Approved")]
        Approved,

        [Description("Rejected")]
        Rejected,

        [Description("Auto Completed")]
        AutoCompleted,      

        //[Description("Withdrawn")]
        //Withdrawn,

        [Description("NotInitiated")]
        NotInitiated
    }
}
