using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Workflow.Common;
using Workflow.Domain.Contracts;
using Workflow.Model;
using Workflow.Repository.Contract;

namespace Workflow.Domain
{
    public class UserDomaian : IUserDomain
    {
        private readonly IAutoMapConverter<Entites.User, User> mapEntityToDomainModel;
        private readonly IAutoMapConverter<User,Entites.User> mapDomainToEntityModel;

        private readonly IUserRepository userRepository;
        public UserDomaian(IUserRepository userRepository, IAutoMapConverter<Entites.User, User> mapEntityToDomainModel,
            IAutoMapConverter<User, Entites.User> mapDomainToEntityModel)
        {
            this.userRepository = userRepository;
            this.mapEntityToDomainModel = mapEntityToDomainModel;
            this.mapDomainToEntityModel = mapDomainToEntityModel;
        }
        public async Task<IList<User>> GetAllUser()
        {            
            var data = await userRepository.GetAllUser();
            return this.mapEntityToDomainModel.ConvertObjectCollection(data);
        }

        public Task<User> GetUser(long Id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUser(string Name)
        {
            throw new NotImplementedException();
        }
    }
}
