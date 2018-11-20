using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Workflow.Repository.Contract
{
    public interface IWorkflowConfiguration
    {
       Task<IList<Workflow.Entites.WorkflowConfiguration>> GetAllConfiguration();

    }
}
