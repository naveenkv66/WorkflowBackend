using DbClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Workflow.Entites;
using Workflow.Repository.Contract;

namespace Workflow.Repository
{
    public class UserRepository : RepositoryBase<User>,IUserRepository
    {
        private DbClient.WorkflowDataContext dbContext;
        public UserRepository(WorkflowDataContext dbContext) :base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IList<User>> GetAllUser()
        {
           return await this.GetAllAsync();
        }


        public async Task<User> GetUser(long Id)
        {
            return await this.GetByIdAsync(Id);
        }

        public async Task<User> GetUser(string name)
        {
            return await this.FindAsync(item => item.UserName == name);
        }
    }
}
