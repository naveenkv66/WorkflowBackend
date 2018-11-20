using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Workflow.Common;
using Workflow.Domain.Contracts;
using Workflow.Model;

namespace Workflow.Domain
{
    public class WorkFlowConfigurationDomain : Workflow.Domain.Contracts.IWorkFlowConfigurationDomain
    {
        private readonly IAutoMapConverter<Entites.WorkflowConfiguration, WorkflowConfiguration> mapEntityToDomainModel;
        private readonly IAutoMapConverter<Entites.WorkflowConfiguration, WorkflowConfiguration> mapDomainToEntityModel;

        private readonly Workflow.Repository.Contract.IWorkflowConfiguration wfConfigRepo;
        public WorkFlowConfigurationDomain(IAutoMapConverter<Entites.WorkflowConfiguration, WorkflowConfiguration> mapEntityToDomainModel,
           IAutoMapConverter<Entites.WorkflowConfiguration, WorkflowConfiguration> mapDomainToEntityModel, Workflow.Repository.Contract.IWorkflowConfiguration wfConfigRepo)
        {
            this.mapDomainToEntityModel = mapDomainToEntityModel;
            this.mapEntityToDomainModel = mapEntityToDomainModel;
            this.wfConfigRepo = wfConfigRepo;
        }

        public async Task<List<WorkflowConfiguration>> GetAllWorkflowConfiguration()
        {
            var data = await this.wfConfigRepo.GetAllConfiguration();
            return this.mapEntityToDomainModel.ConvertObjectCollection(data);
        }
    }
}

