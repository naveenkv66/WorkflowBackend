using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Workflow.Domain.Contracts
{
    public interface IWorkFlowConfigurationDomain
    {
         Task<List<Workflow.Model.WorkflowConfiguration>> GetAllWorkflowConfiguration();
    }
}
