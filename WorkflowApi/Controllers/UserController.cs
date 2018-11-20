using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Workflow.Domain;
using Workflow.Domain.Contracts;

namespace WorkflowApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserDomain userDomaian;
        public UserController(IUserDomain userDomaian)
        {
            this.userDomaian = userDomaian;
        }
        [HttpGet]
        public async Task<IList<Workflow.Model.User>> GetAll()
        {
            return await this.userDomaian.GetAllUser();
        }
    }
}