using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workflow.Infrastructure.Enums;

namespace Workflow.Model
{
    

    public class Task
    {
        public long Id { get; set; }

        public Nullable<long> ActionUserId { get; set; }

        public Nullable<long> ActionGroupId { get; set; }

        public byte WorkflowStateId { get; set; }

        public long WorkflowConfigurationId { get; set; }

        public Guid WorkflowInstanceId { get; set; }

        public bool IsEscalated { get; set; }

        public bool IsNotResponded { get; set; }

        public bool IsCompleted { get; set; }

        public bool IsActive { get; set; }

        public Nullable<DateTime> ActionDate { get; set; }

        public System.DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public Nullable<System.DateTime> LastModifiedDate { get; set; }

        public string LastModifiedBy { get; set; }

        public StatusType Action { get; set; }

        public string Approver { get; set; }

        public string Comments { get; set; }

        public string Remarks { get; set; }

        public bool IsDelegated { get; set; }

        public Nullable<long> DelegatedFrom { get; set; }

        public string DelegatedBy { get; set; }

        public string DelegationComments { get; set; }

        public Nullable<DateTime> DelegatedDate { get; set; }

        public bool IsActionOnlyRequiredTask { get; set; }

        public bool IsGroupTask { get; set; }

        public bool IsLocked { get; set; }

        public Nullable<long> AssignedTo { get; set; }

        public Nullable<long> AssignedBy { get; set; }

        public string GroupName { get; set; }
    }
}
