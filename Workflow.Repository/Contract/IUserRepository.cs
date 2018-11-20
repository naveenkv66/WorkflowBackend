using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Workflow.Entites;

namespace Workflow.Repository.Contract
{
    public interface IUserRepository
    {
        Task<IList<User>> GetAllUser();

        Task<User> GetUser(long Id);

        Task<User> GetUser(string Name);

    }
}
