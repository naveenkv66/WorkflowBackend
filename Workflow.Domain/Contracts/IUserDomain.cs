using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Workflow.Model;

namespace Workflow.Domain.Contracts
{
    public interface IUserDomain
    {
        Task<IList<User>> GetAllUser();

        Task<User> GetUser(long Id);

        Task<User> GetUser(string Name);
    }
}
