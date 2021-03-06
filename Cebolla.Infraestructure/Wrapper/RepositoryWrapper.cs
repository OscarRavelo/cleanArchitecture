using Cebolla.Infraestructure.Context;
using Cebolla.Infraestructure.Interfaces;
using Cebolla.Infraestructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cebolla.Infraestructure.Wrapper
{
   public class RepositoryWrapper : IRepositoryWrapper
    {
        private EntityContext _repoContext;

        public IUserRepository _user;


        public RepositoryWrapper(EntityContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }

        public IUserRepository User
        {
            get
            {
                if (_user == null)
                {
                    _user = new UserRepository(_repoContext);
                }

                return _user;
            }
        }

        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
