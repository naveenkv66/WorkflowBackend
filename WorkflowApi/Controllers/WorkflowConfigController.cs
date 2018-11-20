using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Workflow.Domain.Contracts;

namespace WorkflowApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkflowConfigController : ControllerBase
    {
        private IWorkFlowConfigurationDomain workFlowConfigurationDomain;
        public WorkflowConfigController(IWorkFlowConfigurationDomain workFlowConfigurationDomain)
        {
            this.workFlowConfigurationDomain = workFlowConfigurationDomain;
        }

        [HttpGet]
        public async Task<List<Workflow.Model.WorkflowConfiguration>> GetAll()
        {
           return await this.workFlowConfigurationDomain.GetAllWorkflowConfiguration();   
        }
    }
}