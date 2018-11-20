using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Workflow.Domain.Contracts;

namespace WorkflowApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private DbClient.WorkflowDataContext dbContext;

        IWorkFlowConfigurationDomain workFlowConfigurationDomain;
        //public ValuesController(IWorkFlowConfigurationDomain workFlowConfigurationDomain, DbClient.WorkflowDataContext dbContext)
        //{
        //    this.workFlowConfigurationDomain = workFlowConfigurationDomain;
        //}
        // GET api/values
        [HttpGet(Name ="")]
        public async Task<ActionResult<IEnumerable<string>>> Get()
        {
           //var data = await this.workFlowConfigurationDomain.GetAllWorkflowConfiguration();
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
