using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workflow.Infrastructure.Enums
{
    public enum ApprovalUserType : byte
    {

        [Description("None")]
        None = 0,

        [Description("User")]
        User = 1,

        [Description("Role")]
        Role = 2,

        [Description("Group")]
        Group = 3,
    }
}
