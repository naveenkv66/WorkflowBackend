using System;
using System.Collections.Generic;
using System.Text;

namespace Workflow.Entites
{
    public class RequestType
    {
        public long Id { get; set; }

        public string RequestTypeDesc { get; set; }

        public bool IsActive { get; set; }

        public List<WorkflowConfiguration> WorkflowConfiguration { get; set; }
    }
}
