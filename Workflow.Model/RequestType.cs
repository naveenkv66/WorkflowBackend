using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workflow.Model
{
    [Table("WF_RequestType")]

    public class RequestType
    {
        public long Id { get; set; }

        public string RequestTypeDesc { get; set; }

        public bool IsActive { get; set; }

        public List<WorkflowConfiguration> WorkflowConfigurations { get; set; }

    }
}
