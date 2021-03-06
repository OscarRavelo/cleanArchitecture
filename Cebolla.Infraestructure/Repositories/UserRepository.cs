using Cebolla.Infraestructure.Context;
using Cebolla.Infraestructure.Interfaces;
using Cebolla.Infraestructure.Models;
using Cebolla.Infraestructure.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cebolla.Infraestructure.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(EntityContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
