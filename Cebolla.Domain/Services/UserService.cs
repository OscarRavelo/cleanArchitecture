using Cebolla.Domain.Interfaces;
using Cebolla.Infraestructure.Models;
using Cebolla.Infraestructure.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cebolla.Domain.Services
{
    public class UserService : IUserService
    {
        protected IRepositoryWrapper repo { get; set; }

        public UserService(IRepositoryWrapper _repo)
        {
            repo = _repo;
        }
        public IQueryable<User> Get()
        {
            return repo.User.FindAll();
        }

        public void Create(User user)
        {
            repo.User.Create(user);
            repo.Save();
        }
    }
}
