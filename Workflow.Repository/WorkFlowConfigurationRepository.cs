using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Workflow.Entites;
using Workflow.Repository.Contract;

namespace Workflow.Repository
{
    public class WorkFlowConfigurationRepository : RepositoryBase<Workflow.Entites.WorkflowConfiguration>,Workflow.Repository.Contract.IWorkflowConfiguration
    {
        private DbClient.WorkflowDataContext dbContext;
        public WorkFlowConfigurationRepository(DbClient.WorkflowDataContext dbContext) :base(dbContext)
        {
            this.dbContext = dbContext;
        }
      
        public async Task<IList<WorkflowConfiguration>> GetAllConfiguration()
        {
            return await this.GetAllAsync();
        }
    }
}
