using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workflow.Model
{
    [Table("WF_WorkflowConfiguration")]

    public class WorkflowConfiguration
    {
        public long Id { get; set; }

        public string WorkflowName { get; set; }

        public string Description { get; set; }

        public long RequestTypeId { get; set; }

        public long? EndpointSystemId { get; set; }

        public string ApplicableUserTypes { get; set; }

        public string ApplicableAccountTypes { get; set; }

        public string ApplicableActionTypes { get; set; }

        public bool IsActive { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string LastModifiedBy { get; set; }

        public Nullable<DateTime> LastModifiedDate { get; set; }

        public List<WorkflowConfigurationDetail> WorkflowConfigurationDetails { get; set; }

        public RequestType RequestTypes { get; set; }
    }
}
